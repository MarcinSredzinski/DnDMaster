using MongoDB.Bson.Serialization.Attributes;
using PersistanceLibrary.MongoSpecific;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mongo.Test.UI.CRUDTests
{
    public class BasicCRUDTests
    {
        #region Local variables
        MongoCRUD _db;
        TestableItem _testObject;
        readonly string _tableName = "dania";
        readonly string _dbName = "test1";
        #endregion

        internal void RunTests()
        {
            Console.WriteLine("Initializing variables:");
            InitializeVariables();
            Console.WriteLine("Initializing database connection.");
            try
            {
                TestableItem item;
                ConnectionTest();
                InsertionTest();
                var elements = LoadTest();
                if (elements.Any())
                {
                    item = LoadItemByIdTest(elements.FirstOrDefault().Id);
                    RemovalTest(item.Id);
                }
                else
                {
                    throw new ArgumentNullException(nameof(elements));
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("All tests completed successfuly");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception exc)
            {
                Console.WriteLine("Something went wrong: ");
                Console.WriteLine(exc.ToString());
            }
        }
        private void InitializeVariables()
        {
            _testObject = new TestableItem() { Id = new Guid(), Name = "Item", Weight = 15 };
        }
        private void ConnectionTest()
        {
            _db = new MongoCRUD(_dbName);
            Console.WriteLine("Connection successfull.");
        }
        private void InsertionTest()
        {
            Console.WriteLine("Attempting to write to the database.");

            _db.InsertRecord<object>(_tableName, _testObject);
            Console.WriteLine("Insert successfull.");
        }
        private void RemovalTest(Guid id)
        {
            Console.WriteLine($"Attemptiong to remove element of id:{id}");
            _db.DeleteRecord<TestableItem>(_tableName, id);
            Console.WriteLine("Succesfuly removed element.");
        }
        private List<TestableItem> LoadTest()
        {
            Console.WriteLine("Attempting to load");
            var elements = _db.LoadRecords<TestableItem>(_tableName);
            if (elements.Any())
            {
                Console.WriteLine("Load successfull.");
            }
            return elements;
        }
        private TestableItem LoadItemByIdTest(Guid id)
        {
            Console.WriteLine("Attempting to load element by id");
            var element = _db.LoadById<TestableItem>(_tableName, id);
            if (element != null)
            {
                Console.WriteLine("Load successfull");
            }
            return element;
        }
    }
}
