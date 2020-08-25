using System;

namespace Service.Dal
{
    /// <summary>
    /// Запись об изменении состояния задачи на импорт
    /// </summary>
    public class ImportTaskChangeLogComment
    {
        /// <summary>
        /// Идентификатор записи об изменении состояния
        /// </summary>
        /// <value></value>
        public int ChangeLogId { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        /// <value></value>
        public string Comment { get; set; } = String.Empty;
    }
}