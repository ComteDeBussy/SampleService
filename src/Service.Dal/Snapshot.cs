using System;

namespace Service.Dal
{
    /// <summary>
    /// Описание снапшота
    /// </summary>
    public class Snapshot
    {
        /// <summary>
        /// Идентификатор снапшота
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор задачи, для которой сделан снапшот
        /// </summary>
        /// <value></value>
        public int TaskId { get; set; }

        /// <summary>
        /// Дата создания снапшота
        /// </summary>
        /// <value></value>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Имя человека
        /// </summary>
        /// <value></value>
        public string? FirstName {get;set;}

        /// <summary>
        /// Фамилия человека
        /// </summary>
        /// <value></value>
        public string? LastName {get;set;}

        /// <summary>
        /// Отчество человека
        /// </summary>
        /// <value></value>
        public string? FatherName {get;set;}
    }
}