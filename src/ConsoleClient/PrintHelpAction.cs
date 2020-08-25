using System;

namespace Service.ConsoleClient
{
    /// <summary>
    /// Действие просто выводит в консоль подсказку по использованию утилиты
    /// </summary>
    class PrintHelpAction : IAction
    {
        /// <summary>
        /// Выводит подсказку в консоль
        /// </summary>
        public void Do()
        {
            Console.WriteLine(@"Утилита показывает список задач и подгруженных данных по доходам клиента.

Для получения списка задач вызывать со следующими параметрами:

ConsoleClient show tasks

Для получения списка доходов по клиенту вызывать со следующими параметрами:

ConsoleClient show incomes <absId>

где absId — идентификатор клиента в АБС.");

        }
    }
}