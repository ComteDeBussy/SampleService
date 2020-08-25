using System;
using Service.Abstractions;
using Service.Dal;

namespace Service.BL
{
    /// <summary>
    /// Различные методы расширения
    /// </summary>
    static class Extensions
    {
        /// <summary>
        /// Заполняет модель даными из моделей слоя DAL
        /// </summary>
        /// <param name="task">Задача на импорт</param>
        /// <param name="taskRecord">Запись из базы о задаче на импорт</param>
        /// <param name="changeLogRecord">Запись из базы о последнем изменении состояния задачи на импорт</param>
        /// <returns></returns>
        public static ImportTask FillFromDalEntities(this ImportTask task, ImportTaskRecord taskRecord, ImportTaskChangeLogRecord changeLogRecord)
        {
            task.AbsId = taskRecord.AbsId;
            task.ExternalId = taskRecord.ExternalId;
            task.ChangedAt = changeLogRecord.CreatedAt;

            switch (changeLogRecord.State)
            {
                case 0:
                    task.State = ImportTaskStates.Waiting;
                    break;
                case 1:
                    task.State = ImportTaskStates.Done;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Неизвестный код состояния {changeLogRecord.State}", nameof(changeLogRecord));
            }
            return task;
        }

        /// <summary>
        /// Заполняет модель даными из моделей слоя DAL
        /// </summary>
        /// <param name="transaction">Транзакция с доходами</param>
        /// <param name="dalRecord">Запись из базы о транзакции</param>
        /// <returns></returns>
        public static IncomeTransaction FillFromDalEntities(this IncomeTransaction transaction, SnapshotRecord dalRecord)
        {
            transaction.ContractorName = dalRecord.ContractorName;
            transaction.CreditAccountNumber = dalRecord.CreditAccountNumber;
            transaction.Date = dalRecord.TransactionDate;
            transaction.DebitAccountNumber = dalRecord.DebitAccountNumber;
            transaction.Puprose = dalRecord.PaymentPurpose;
            transaction.Sum = dalRecord.IncomeSum;

            switch (dalRecord.TransactionType)
            {
                case 0:
                    transaction.Type = IncomeTypes.Salary;
                    break;
                case 1:
                    transaction.Type = IncomeTypes.Pension;
                    break;
                case 2:
                    transaction.Type = IncomeTypes.Service;
                    break;
            }

            return transaction;
        }


    }
}