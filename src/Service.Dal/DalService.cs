using System;
using System.Linq;

namespace Service.Dal
{
    /// <summary>
    /// Эмулирует сервис для работы с хранилищем данных.
    /// </summary>
    /// <remarks>
    /// Структура хранилища соответствует описанию в задаче на разработку сервиса
    /// импорта доходов. Но сам сервис содержит только методы для чтения — для демонстрации
    /// этого достаточно.
    /// </remarks>
    public class DalService
    {
        /// <summary>
        /// Возвращает все задачи на импорт данных
        /// </summary>
        /// <returns></returns>
        public ImportTaskRecord[] Tasks()
        {
            return Storage.Tasks;
        }

        /// <summary>
        /// Возвращает все записи об изменениях состояний всех задач
        /// </summary>
        /// <returns></returns>
        public ImportTaskChangeLogRecord[] TaskChangeLogs()
        {
            return Storage.TaskChangesLog;
        }

        /// <summary>
        /// Возвращает все имеющиеся снапшоты с импортированными данными
        /// </summary>
        /// <returns></returns>
        public Snapshot[] Snapshots()
        {
            return Storage.Snapshots;
        }

        /// <summary>
        /// Возвращает все записи о доходах со всех снапшотов
        /// </summary>
        /// <returns></returns>
        public SnapshotRecord[] SnapshotRecords()
        {
            return Storage.SnapshotRecords;
        }
    }
}
