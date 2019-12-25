using Mongo.Test.UI.CRUDTests;
using PersistanceLibrary.MongoSpecific;
using System;

namespace Mongo.Test.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCRUDTests basicCRUDTests = new BasicCRUDTests();
            basicCRUDTests.RunTests();
            Console.ReadLine();
        }
    }
}
