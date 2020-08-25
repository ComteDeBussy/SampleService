using System;
using Service.Abstractions;

namespace Service.ConsoleClient
{
    /// <summary>
    /// Действие, выводящее в консоль список задач
    /// </summary>
    class PrintTasksAction : IAction
    {
        private IIncomesService _incomeService;
        public PrintTasksAction(IIncomesService service)
        {
            _incomeService = service;
        }

        /// <summary>
        /// Выводит в консоль список задач
        /// </summary>
        public void Do()
        {
            Console.WriteLine("|              ID задачи               | ABS ID  | Статус  |  Дата изменения статуса   |");
            Console.WriteLine("+--------------------------------------+---------+---------+---------------------------+");

            foreach(var task in _incomeService.GetTasks())
            {
                Console.WriteLine($"| {task.ExternalId} | {task.AbsId,7} | {task.State,-7} | {task.ChangedAt.ToLocalTime().ToString("yyyy-MM-dd HH:mm:sszzz")} |");
            }
        }
    }
}