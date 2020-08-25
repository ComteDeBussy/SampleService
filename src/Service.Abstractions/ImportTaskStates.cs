namespace Service.Abstractions
{
    /// <summary>
    /// Возможные состояния задачи на импорт данных
    /// </summary>
    public enum ImportTaskStates
    {
        ///<summary>Ожидание импорта</summary>
        Waiting,

        ///<summary>Завершена</summary>
        Done
    }
}