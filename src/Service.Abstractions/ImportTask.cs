using System;

namespace Service.Abstractions
{
    /// <summary>
    /// Задача на импорт данных по доходам из АБС
    /// </summary>
    public class ImportTask
    {
        /// <summary>
        /// Внешний идентификатор задачи на импорт
        /// </summary>
        /// <value></value>
        public Guid ExternalId {get;set;}

        /// <summary>
        /// АБС-идентификатор клента в АБС, для которого поставлена задача на импорт
        /// </summary>
        /// <value></value>
        public int AbsId {get;set;}

        /// <summary>
        /// Состояние задачи
        /// </summary>
        /// <value></value>
        public ImportTaskStates State {get;set;}

        /// <summary>
        /// Дата последнего изменения состояния задачи
        /// </summary>
        /// <value></value>
        public DateTime ChangedAt {get;set;}
    }
}
