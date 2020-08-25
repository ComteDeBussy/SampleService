using System;

namespace Service.Abstractions
{
    /// <summary>
    /// Интерфейс для бизнес-логики сервиса по доходам
    /// </summary>
    public interface IIncomesService
    {
        /// <summary>
        /// Возвращает все задачи на импорт, присутствующие в системе, а также
        /// их актуальное состояние и дату изменения этого состояния
        /// </summary>
        /// <returns></returns>
        public ImportTask[] GetTasks();

        /// <summary>
        /// Для заданного клиента возвращает все задачи на импорт, присутствующие в системе,
        /// а также их актуальное состояние и дату изменения этого состояния
        /// </summary>
        /// <param name="absId">Идентификатор клиента в АБС</param>
        /// <returns></returns>
        public ImportTask[] GetTasks(int absId);

        /// <summary>
        /// Возвращает задачу на импорт по её внешнему идентификатору
        /// </summary>
        /// <param name="extId">Внешний идентификатор задачи</param>
        /// <returns></returns>
        public ImportTask GetTask(Guid extId);

        /// <summary>
        /// Для заданного клиента возвращает последнюю импортированную информацию
        /// о всех его доходах, включая нераспознанные как зарплата/пенсия/ЕДВ/ЖКУ
        /// </summary>
        /// <param name="absId"></param>
        /// <returns></returns>
        public IncomeTransaction[] GetClientIncomeTransactions(int absId);

    }
}
