using System;
using Service.Abstractions;

namespace Service.RestApi.Models
{
    public class IncomeModelV2 : IncomeModel
    {

        public IncomeModelV2()
            : base()
        {

        }

        public IncomeModelV2(IncomeTransaction transaction)
            : base(transaction)
        {
            DebitAccount = transaction.DebitAccountNumber;
            CreditAccount = transaction.CreditAccountNumber;
            ContractorInn = transaction.ContractorInn;
            Purpose = transaction.Puprose;
        }

        public decimal DebitAccount { get; set; }

        public decimal CreditAccount { get; set; }

        public long ContractorInn { get; set; }

        public string Purpose { get; set; } = String.Empty;
    }
}