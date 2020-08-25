using System;

namespace Service.Dal
{
    /// <summary>
    /// Запись об изменении состояния задачи на импорт
    /// </summary>
    public class ImportTaskChangeLogRecord
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор задачи на импорт
        /// </summary>
        /// <value></value>
        public int TaskId { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        /// <value></value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Состояние задачи
        /// </summary>
        /// <value></value>
        public int State {get;set;}
    }
}