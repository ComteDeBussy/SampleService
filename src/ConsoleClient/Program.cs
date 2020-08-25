using System;
using Service.BL;

namespace Service.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetAction(args).Do();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Парсит параметры и возвращает соответствующее действие
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static IAction GetAction(string[] args)
        {
            if (args.Length < 2
                || args.Length > 3
                || string.Compare(args[0], "show", true) != 0)
                return new PrintHelpAction();

            if (string.Compare(args[1], "tasks", true) == 0)
                return new PrintTasksAction(new IncomeService());

            if (string.Compare(args[1], "incomes", true) == 0)
            {
                if (args.Length == 3 && int.TryParse(args[2], out var absId))
                    return new PrintIncomesAction(new IncomeService(), absId);
            }

            return new PrintHelpAction();
        }
    }
}
