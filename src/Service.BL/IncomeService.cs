using System;
using System.Linq;
using Service.Abstractions;
using Service.Dal;

namespace Service.BL
{
    /// <summary>
    /// Класс с основной бизнес-логикой сервиса
    /// </summary>
    public class IncomeService : IIncomesService
    {
        private DalService _dalService;

        /// <summary>
        /// Возвращает экземпляр сервиса
        /// </summary>
        public IncomeService()
        {
            /*
                Вообще, тут должен быть Dependency Injection, но для упрощения сделано прямое
                создание нужного класса DAL-уровня прямо в конструкторе.

                Как правило, бизнес-логика довольно плотно взаимодействует с DAL-уровнем.
                От выбранного способа хранения данных и от выбранной конкретной СУБД зависит
                довольно многое.

                Даже если брать класс реляционных СУБД, то в зависимости
                от конкретной СУБД бизнес-логика может быть написана по-разному: для MS SQL
                одним образом, для PostgreSQL — другим, для Oracle — вообще третьим. Всякие
                красивые идеи про то, что ORM помогает сделать быстрый переход с одной СУБД
                на другую — как правило, бред полный. На больших проектах это никогда не работает
                быстро — только долго и с болью.

                Если же рассматривать класс NoSQL СУБД, то тут бизнес-логика может быть написана
                совершенно иначе.

                И в обоих случаях связь между уровнями BL и DAL — она достаточно тесная. Поэтому
                иногда не так страшно отойти от красивых паттернов, вроде DI, в сторону упрощения,
                как это сделано в данном примере.
            */
            _dalService = new DalService();
        }

        /// <summary>
        /// Возвращает все существующие задачи на импорт данных
        /// вместе с их актуальными статусами и датами изменения статусов
        /// </summary>
        /// <returns></returns>
        public ImportTask[] GetTasks()
        {
            return _dalService.Tasks()
                            .GroupJoin(  _dalService.TaskChangeLogs(),
                                    k1 => k1.Id,
                                    k2 => k2.TaskId,
                                    (task, changeLog) => new ImportTask().FillFromDalEntities(task,
                                                                                            changeLog.OrderByDescending(i => i.CreatedAt)
                                                                                                    .First()
                                                                                            )
                                    )
                            .ToArray();
        }

        /// <summary>
        /// Для переданного absId dозвращает все существующие задачи на импорт данных
        /// вместе с их актуальными статусами и датами изменения статусов
        /// </summary>
        /// <param name="absId"></param>
        /// <returns></returns>
        public ImportTask[] GetTasks(int absId)
        {
            return _dalService.Tasks()
                            .Where(t => t.AbsId == absId)
                            .GroupJoin(  _dalService.TaskChangeLogs(),
                                    k1 => k1.Id,
                                    k2 => k2.TaskId,
                                    (task, changeLog) => new ImportTask().FillFromDalEntities(task,
                                                                                            changeLog.OrderByDescending(i => i.CreatedAt)
                                                                                                    .First()
                                                                                            )
                                    )
                            .ToArray();
        }

        /// <summary>
        /// По переданному внешнему идентификатору возвращает задачу на импорт,
        /// её актуальный статус и дату изменения статуса
        /// </summary>
        /// <param name="extId"></param>
        /// <returns></returns>
        /// <exception cref="Aeb.SampleService.BL.ImportTaskNotFoundException">
        /// Выбрасывается в случае, если задача с переданным идентификатором не найдена
        /// </exception>
        public ImportTask GetTask(Guid extId)
        {
            return  GetTasks().FirstOrDefault(item => item.ExternalId == extId)
                    ?? throw new ImportTaskNotFoundException(extId);
        }

        /// <summary>
        /// Для переданного absId возвращает все приходные транзакции с распознаннм
        /// признаком типа дохода
        /// </summary>
        /// <param name="absId">Идентификатор клиента из АБС</param>
        /// <returns></returns>
        /// <exception cref="Aeb.SampleService.BL.ClientNotFoundException">
        /// Выбрасывается в случае, если для переданного absId не было задач на импорт
        /// </exception>
        /// <exception cref="Aeb.SampleService.BL.ImportNotCompletedException">
        /// Выбрасывается в случае, если для переданного absId ни одна задача на импорт
        /// ещё не была звершена
        /// </exception>
        public IncomeTransaction[] GetClientIncomeTransactions(int absId)
        {
            // Выбираем все задачи на импорт для переданного absId,
            // для каждой задачи из последнегго изменения состояния выбираем берём статус,
            // по умолчанию проставляя его в 0
            var tasks = _dalService.Tasks()
                                    .Where(t => t.AbsId == absId)
                                    .GroupJoin( _dalService.TaskChangeLogs(),
                                                k1 => k1.Id,
                                                k2 => k2.TaskId,
                                                (task, changelog) => new {
                                                                            Task = task,
                                                                            LastState = changelog.OrderByDescending(c => c.CreatedAt).FirstOrDefault()?.State ?? 0
                                                                        }
                                                );

            // Ошибка, если задач на импорт для переданного absId вообще не было
            if (tasks.Count() == 0)
                throw new ClientNotFoundException(absId);

            // Ошибка, если для переданного absId нет ни одной завершённой задачи на импорт
            if (!tasks.Any(item => item.LastState == 1))
                throw new ImportNotCompletedException(absId);

            // Выбираем самый последний по дате создания снапшот для переданного absId
            var lastShapshot = _dalService.Snapshots()
                                            .Join(  tasks,
                                                    k1 => k1.TaskId,
                                                    k2 => k2.Task.Id,
                                                    (snapshot, task) => snapshot
                                                )
                                            .OrderByDescending(s => s.CreatedAt)
                                            .FirstOrDefault();
            // Перестраховываемся на случай, если в базе данные несогласованы, и снапшот отсутствует
            if (lastShapshot == null)
                throw new ImportNotCompletedException(absId);

            return _dalService.SnapshotRecords()
                                .Where(s => s.SnapshotId == lastShapshot.Id)
                                .Select(s => new IncomeTransaction().FillFromDalEntities(s))
                                .ToArray();

        }

    }
}