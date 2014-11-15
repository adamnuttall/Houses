using Houses.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Houses.App_Start
{
    public class HousesContext
    {
        public MongoDatabase Database;

        public HousesContext()
        {
            var client = new MongoClient(Settings.Default.HousesConnectionString);
            var server = client.GetServer();
            Database = server.GetDatabase(Settings.Default.HousesDatabaseName);
        }
    }
}