using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersistanceLibrary.MongoSpecific
{
    public class MongoCRUD : IMongoCRUD
    {
        private IMongoDatabase _db;
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            _db = client.GetDatabase(database);
        }
        public void InsertRecord<T>(string table, T record)
        {
            var collection = _db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
        public List<T> LoadRecords<T>(string table)
        {
            var collection = _db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }
        public T LoadById<T>(string table, Guid id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }
        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = _db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
        public void Upsert<T>(string table, Guid id, T record)
        {
            var collection = _db.GetCollection<T>(table);
            var result = collection.ReplaceOne(
                new BsonDocument("id", id),
                record,
                new UpdateOptions { IsUpsert = true });
        }
    }
}
