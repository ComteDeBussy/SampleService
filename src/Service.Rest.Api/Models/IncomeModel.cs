using System;
using Service.Abstractions;

namespace Service.RestApi.Models
{
    /// <summary>
    /// Моделька для возврата из контроллера
    /// </summary>
    public class IncomeModel
    {
        public IncomeModel()
        {

        }

        public IncomeModel(IncomeTransaction transaction)
        {
            Date = transaction.Date;
            Sum = transaction.Sum;
            ContractorName = transaction.ContractorName;
            switch (transaction.Type)
            {
                case IncomeTypes.Salary:
                    IncomeType = "salary";
                    break;
                case IncomeTypes.Pension:
                    IncomeType = "pension";
                    break;
                case IncomeTypes.Service:
                    IncomeType = "service";
                    break;
            }
        }

        public DateTime Date {get;set;}

        public Decimal Sum {get;set;}

        public string ContractorName {get;set;} = String.Empty;
        public string? IncomeType {get;set;}
    }
}