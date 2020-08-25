using System;
namespace Service.BL
{
    /// <summary>
    /// Исключение, выбрасываемое в случае, когда задача на импорт данных не найдена
    /// </summary>
    public class ImportTaskNotFoundException : Exception
    {
        public Guid TaskExternalId {get; private set;}
        public ImportTaskNotFoundException(Guid taskExternalId)
            : base($"Задача на импорт с идентификатором {taskExternalId.ToString()} не найдена")
        {
            TaskExternalId = taskExternalId;
        }
    }

    /// <summary>
    /// Исключение, выбрасываемое в случае, когда заданный клиент не найден в базе импортированных доходов
    /// </summary>
    public class ClientNotFoundException : Exception
    {
        public int AbsId {get; private set;}
        public ClientNotFoundException(int absId)
            : base($"Импорта данных для клиента с AbsID = {absId} не производился")
        {
            AbsId = absId;
        }
    }

    /// <summary>
    /// Исключение, выбрасываемое в случае, когда задача на импорт данных для заданного клиента ещё не завершена
    /// </summary>
    public class ImportNotCompletedException : Exception
    {
        public int AbsId {get; private set;}
        public ImportNotCompletedException(int absId)
            : base($"Импорт данных для клиента с AbsID = {absId} ещё не завершён")
        {
            AbsId = absId;
        }
    }
}