using System;

namespace Service.Dal
{
    /*
    Просто нагенерированные GUIDы для примеров
    10e9328d-71bb-4768-afd4-29f95d00aebc
    3a9b0992-0785-4967-ae5b-3ededb69b13e
    073c73a9-8b48-4ebb-b792-c16dfddf1e85
    3c3ad4f8-3cb3-49ca-910f-3fece32bb766
    dd2a7cda-4fc6-4e26-a20d-850b01654495
    02e9b1b0-bbe1-49c6-84f7-66119cbf1805
    f7281620-7616-4b39-be51-5d3c74ba8322
    2efcb5c3-5c0a-42da-b5f8-077b771896ed
    bf38100b-281e-4205-9f4e-c52c0e9a977e
    5404ed4e-6088-484c-8458-64e7f625770c
    8dd1c2d8-87a3-4ba6-a70f-542fd8b8812e
    8f312ab2-a94b-4f44-8ccb-cbc60f2ac533
    89fbff76-b8b3-4379-8dbe-1cbe5edb7e27
    7d8eb729-c68a-497e-886e-caa5c43e188e
    7c7fed38-a06b-4ed5-85c8-6270c6588130
    1e691669-c77c-4c68-9d6a-417abf0f8ed6
    0372d17b-bdd2-4718-aed1-99c2357a516a
    */

    /// <summary>
    /// Эмуляция хранилища данных
    /// </summary>
    class Storage
    {
        public static ImportTaskRecord[] Tasks = new ImportTaskRecord[] {
            new ImportTaskRecord {Id = 1, ExternalId = Guid.Parse("afdc13f9-2729-4f52-9d0b-74f6a543a2d7"), AbsId=101},
            new ImportTaskRecord {Id = 2, ExternalId = Guid.Parse("ebb927f7-b733-44a3-9869-b12f915850fb"), AbsId=205},
            new ImportTaskRecord {Id = 30, ExternalId = Guid.Parse("f6c12349-bc80-40a4-a5f0-26ea602c26e0"), AbsId=1225}
        };

        public static ImportTaskChangeLogRecord[] TaskChangesLog = new ImportTaskChangeLogRecord[]
        {
            new ImportTaskChangeLogRecord {Id = 1, TaskId = 1, CreatedAt = new DateTime(2020, 08, 22, 13, 05, 55, DateTimeKind.Utc), State = 0},
            new ImportTaskChangeLogRecord {Id = 2, TaskId = 1, CreatedAt = new DateTime(2020, 08, 22, 13, 05, 57, DateTimeKind.Utc), State = 1},
            new ImportTaskChangeLogRecord {Id = 3, TaskId = 2, CreatedAt = new DateTime(2020, 08, 22, 14, 12, 22, DateTimeKind.Utc), State = 0},
            new ImportTaskChangeLogRecord {Id = 4, TaskId = 30, CreatedAt = new DateTime(2020, 08, 22, 18, 59, 17, DateTimeKind.Utc), State = 0},
        };

        public static Snapshot[] Snapshots = new Snapshot[]
        {
            new Snapshot {Id = 1, TaskId = 1, CreatedAt = new DateTime(2020, 06, 22, 13, 05, 57, DateTimeKind.Utc), FirstName = "Евгений", FatherName = "Александрович", LastName = "Онегин"},
            new Snapshot {Id = 2, TaskId = 1, CreatedAt = new DateTime(2020, 08, 13, 10, 14, 21, DateTimeKind.Utc), FirstName = "Евгений", FatherName = "Александрович", LastName = "Онегин"}
        };

        public static SnapshotRecord[] SnapshotRecords = new SnapshotRecord[]
        {
            new SnapshotRecord {Id = 1, SnapshotId = 2, TransactionDate = new DateTime(2020, 01, 15, 10, 07, 53, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 51293.12m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1001, AbsId2 = 1002},
            new SnapshotRecord {Id = 2, SnapshotId = 2, TransactionDate = new DateTime(2020, 01, 25, 10, 12, 00, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50922.58m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1003, AbsId2 = 1004},
            new SnapshotRecord {Id = 3, SnapshotId = 2, TransactionDate = new DateTime(2020, 01, 26, 18, 14, 27, DateTimeKind.Utc), ContractorInn = 241896354812, DebitAccountNumber = 40754865415876000156m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 1000m, PaymentPurpose="За посиделки в кафе", ContractorName="Владимир Сергевич Тюлькин", AbsId1 = 1005, AbsId2 = 1006},
            new SnapshotRecord {Id = 4, SnapshotId = 2, TransactionDate = new DateTime(2020, 02, 15, 10, 05, 14, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 54315.12m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1007, AbsId2 = 1007},
            new SnapshotRecord {Id = 5, SnapshotId = 2, TransactionDate = new DateTime(2020, 02, 25, 10, 22, 18, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 49912.14m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1009, AbsId2 = 1010},
            new SnapshotRecord {Id = 6, SnapshotId = 2, TransactionDate = new DateTime(2020, 03, 15, 10, 14, 22, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 51422.32m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1011, AbsId2 = 1012},
            new SnapshotRecord {Id = 7, SnapshotId = 2, TransactionDate = new DateTime(2020, 03, 25, 10, 37, 05, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50190.18m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1013, AbsId2 = 1014},
            new SnapshotRecord {Id = 8, SnapshotId = 2, TransactionDate = new DateTime(2020, 04, 15, 10, 01, 14, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50816.92m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1015, AbsId2 = 1016},
            new SnapshotRecord {Id = 9, SnapshotId = 2, TransactionDate = new DateTime(2020, 04, 25, 10, 18, 34, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50140.14m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1017, AbsId2 = 1018},
            new SnapshotRecord {Id = 10, SnapshotId = 2, TransactionDate = new DateTime(2020, 05, 15, 10, 12, 41, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50218.22m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1019, AbsId2 = 1020},
            new SnapshotRecord {Id = 11, SnapshotId = 2, TransactionDate = new DateTime(2020, 05, 16, 08, 22, 12, DateTimeKind.Utc), ContractorInn = 241896354812, DebitAccountNumber = 40754865415876000156m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 250, PaymentPurpose="За обед", ContractorName="Владимир Сергевич Тюлькин", AbsId1 = 1021, AbsId2 = 1022},
            new SnapshotRecord {Id = 12, SnapshotId = 2, TransactionDate = new DateTime(2020, 05, 25, 10, 52, 32, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 51116.44m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1023, AbsId2 = 1024},
            new SnapshotRecord {Id = 13, SnapshotId = 2, TransactionDate = new DateTime(2020, 06, 15, 10, 14, 14, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50018.32m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1025, AbsId2 = 1026},
            new SnapshotRecord {Id = 14, SnapshotId = 2, TransactionDate = new DateTime(2020, 06, 25, 10, 12, 07, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50106.14m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1027, AbsId2 = 1028},
            new SnapshotRecord {Id = 15, SnapshotId = 2, TransactionDate = new DateTime(2020, 07, 15, 10, 08, 18, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 51018.22m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1029, AbsId2 = 1030},
            new SnapshotRecord {Id = 16, SnapshotId = 2, TransactionDate = new DateTime(2020, 07, 25, 10, 08, 50, DateTimeKind.Utc), ContractorInn = 2418963548, DebitAccountNumber = 40754865415876501750m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 50016.54m, PaymentPurpose="Начисление заработной платы", ContractorName="ООО Заборостроительный трест", TransactionType = 0, AbsId1 = 1031, AbsId2 = 1032},
            new SnapshotRecord {Id = 17, SnapshotId = 2, TransactionDate = new DateTime(2020, 08, 05, 10, 06, 16, DateTimeKind.Utc), ContractorInn = 2485184617, DebitAccountNumber = 40754865415876587895m, CreditAccountNumber = 40854621875321876542m, IncomeSum = 31142.16m, PaymentPurpose="Начисление пенсии", ContractorName="Пенсионный фонд", TransactionType = 1, AbsId1 = 1033, AbsId2 = 1034}
        };
    }
}