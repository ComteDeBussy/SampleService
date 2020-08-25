using System;

namespace Service.Abstractions
{
    /// <summary>
    /// Транзакция с доходами
    /// </summary>
    public class IncomeTransaction
    {
        /// <summary>
        /// Идентификатор транзакции дохода в АБС
        /// </summary>
        /// <value></value>
        public int AbsId { get; set; }

        /// <summary>
        /// Дата дохода
        /// </summary>
        /// <value></value>
        public DateTime Date { get; set; }

        /// <summary>
        /// Суммв дохода
        /// </summary>
        /// <value></value>
        public decimal Sum { get; set; }

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
        /// Название контрагента
        /// </summary>
        /// <value></value>
        public string ContractorName { get; set; } = string.Empty;

        /// <summary>
        /// ИНН контрагента
        /// </summary>
        /// <value></value>
        public long ContractorInn { get; set; }

        /// <summary>
        /// Назначение платежа
        /// </summary>
        /// <value></value>
        public string Puprose { get; set; } = string.Empty;

        /// <summary>
        /// Распознанный тип платежа
        /// </summary>
        /// <value></value>
        public IncomeTypes? Type { get; set; }
    }
}