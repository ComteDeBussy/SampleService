using System;

namespace Service.Dal
{
    /// <summary>
    /// Задача на импорт данных из АБС
    /// </summary>
    public class ImportTaskRecord
    {
        /// <summary>
        /// Идентификатор задачи
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Внешний идентификатор задачи
        /// </summary>
        /// <value></value>
        public Guid ExternalId { get; set; }

        /// <summary>
        /// АБС-идентификатор пользователя, для которого создана задача на импорт
        /// </summary>
        /// <value></value>
        public int AbsId { get; set; }
    }
}