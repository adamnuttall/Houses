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

        
    }
}
