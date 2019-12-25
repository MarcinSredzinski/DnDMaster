using System;
using System.Collections.Generic;

namespace PersistanceLibrary.MongoSpecific
{
    public interface IMongoCRUD
    {
        void DeleteRecord<T>(string table, Guid id);
        void InsertRecord<T>(string table, T record);
        T LoadById<T>(string table, Guid id);
        List<T> LoadRecords<T>(string table);
        void Upsert<T>(string table, Guid id, T record);
    }
}