using System;
using System.Linq;
using Service.Abstractions;

namespace Service.ConsoleClient
{
    /// <summary>
    /// Действие, выводящее в консоль список доходов
    /// </summary>
    class PrintIncomesAction : IAction
    {
        private IIncomesService _incomeService;
        private int _absId;

        public PrintIncomesAction(IIncomesService service, int absId)
        {
            _incomeService = service;
            _absId = absId;
        }

        /// <summary>
        /// Выводит в консоль список доходов
        /// </summary>
        public void Do()
        {
            var task = _incomeService.GetTasks(_absId)
                                        .Where(t => t.State == ImportTaskStates.Done)
                                        .OrderByDescending(t => t.ChangedAt)
                                        .FirstOrDefault();

            if (task != null)
                Console.WriteLine($"Данные о доходах по состоянию на {task.ChangedAt.ToLocalTime().ToString("yyyy-MM-dd HH:mm:sszzz")}\n");

            Console.WriteLine("|      Дата транзакции      |    Сумма    |       Отправитель         |  Назначение платежа  |     Счёт дебита      |     Счёт кредита     |   Доход    |");
            Console.WriteLine("+---------------------------+-------------+---------------------------+----------------------+----------------------+----------------------+------------+");
            foreach(var income in _incomeService.GetClientIncomeTransactions(_absId))
            {
                Console.WriteLine(  "| {0} | {1,11:N2} | {2,-25} | {3,-20} | {4,20} | {5,20} | {6,-10} |",
                                    income.Date.ToLocalTime().ToString("yyyy-MM-dd HH:mm:sszzz"),
                                    income.Sum,
                                    GetShortString(income.ContractorName, 25),
                                    GetShortString(income.Puprose, 20),
                                    income.DebitAccountNumber,
                                    income.CreditAccountNumber,
                                    GetTypeStringOrEmpty(income.Type)
                                );
            }

            string? GetShortString(string value, int maxLength)
            {
                if ((value?.Length ?? 0) <= maxLength)
                    return value;

                return String.Concat(value!.Substring(0,maxLength-3), "...");

            }

            string GetTypeStringOrEmpty(IncomeTypes? incomeType)
            {
                if (incomeType == null)
                    return String.Empty;

                switch (incomeType)
                {
                    case IncomeTypes.Salary:
                        return "Зарплата";
                    case IncomeTypes.Pension:
                        return "Пенсия";
                    default:
                        return "ЕДВ/ЖКУ";
                }
            }
        }
    }
}