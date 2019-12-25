using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Mongo.Test.UI.CRUDTests
{
    internal class TestableItem
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
    }
}

