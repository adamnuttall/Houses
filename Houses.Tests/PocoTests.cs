using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Bson.IO;

namespace Houses.Tests
{
    [TestClass]
    public class PocoTests
    {
        public PocoTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        public class Person
        {
            public string FirstName { get; set; }
            public int Age { get; set; }
        }

        [TestMethod]
        public void Automatic()
        {
            var person = new Person
            {
                Age = 29,
                FirstName = "Adam"
            };

            Console.WriteLine(person.ToString());
        }
    }
}
