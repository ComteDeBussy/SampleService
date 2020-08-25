using System;

namespace Service.Dal
{
    /// <summary>
    /// Запись снапшота
    /// </summary>
    public class SnapshotRecord
    {
        /// <summary>
        /// Идентификатор записи снапшота
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// Идентификатор снапшота
        /// </summary>
        /// <value></value>
        public int SnapshotId { get; set; }

        /// <summary>
        /// Идентификатор транзакции в АБС
        /// </summary>
        /// <value></value>
        public int AbsId1 { get; set; }

        /// <summary>
        /// Идентификатор транзакции в АБС
        /// </summary>
        /// <value></value>
        public int AbsId2 { get; set; }

        /// <summary>
        /// Дата транзакции
        /// </summary>
        /// <value></value>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// ИНН контрагента
        /// </summary>
        /// <value></value>
        public long ContractorInn { get; set; }

        /// <summary>
        /// Счёт дебита
        /// </summary>
        /// <value></value>
        public decimal DebitAccountNumber { get; set; }

        /// <summary>
        /// Счёт кредита
        /// </summary>
        /// <value></value>
        public decimal CreditAccountNumber { get; set; }

        /// <summary>
        /// Сумма транзакции
        /// </summary>
        /// <value></value>
        public decimal IncomeSum { get; set; }

        /// <summary>
        /// Назначение платежа
        /// </summary>
        /// <value></value>
        public string PaymentPurpose { get; set; } = string.Empty;

        /// <summary>
        /// Название контрагента
        /// </summary>
        /// <value></value>
        public string ContractorName { get; set; } = string.Empty;

        /// <summary>
        /// Тип тразакции
        /// </summary>
        /// <value></value>
        public short? TransactionType { get; set; }

    }
}