using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;

namespace Houses.Tests
{
    [TestClass]
    public class BsonDocumentTests
    {
        public BsonDocumentTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [TestMethod]
        public void EmptyDocument()
        {
            var document = new BsonDocument();

            Console.WriteLine(document);
        }

        [TestMethod]
        public void AddElements()
        {
            var person = new BsonDocument
            {
                {"age", new BsonInt32(29)},
                {"IsAlive", true}
            };
            person.Add("firstName", new BsonString("adam"));

            Console.WriteLine(person);
        }

        [TestMethod]
        public void AddingArrays()
        {
            var person = new BsonDocument();
            person.Add("address",
                new BsonArray(new[] {"Flat 1", "101 Some Street"}));

            Console.WriteLine(person);
        }

        [TestMethod]
        public void EmbeddedDocument()
        {
            var person = new BsonDocument
            {
                {
                    "contact", new BsonDocument
                    {
                        {"phone", "0161000000"},
                        {"email", "adam@email.com"}
                    }
                }
            };

            Console.WriteLine(person);
        }

        [TestMethod]
        public void BsonValueConversions()
        {
            var person = new BsonDocument
            {
                {"age", 54},
            };

            Console.WriteLine(person["age"].ToDouble() + 10);
            Console.WriteLine(person["age"].IsInt32);
            Console.WriteLine(person["age"].IsString);
        }

        [TestMethod]
        public void ToBson()
        {
            var person = new BsonDocument
            {
                {"firstName", "adam"},
            };

            var bson = person.ToBson();

            Console.WriteLine(BitConverter.ToString(bson));

            var deserialisedPerson = BsonSerializer.Deserialize<BsonDocument>(bson);
            Console.WriteLine(deserialisedPerson);
        }
    }
}
