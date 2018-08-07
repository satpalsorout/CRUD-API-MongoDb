using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
namespace AssignmentAPI.mongodb
{
    public class MongoContext
    {
        MongoClient _client;
        MongoServer _server;
        public MongoDatabase _database;
        public MongoContext()
        {
            var MongoDatabaseName = "enollementdb";
            var MongoUsername = "enrollmentUser";
            var Mongopassword = "enrollment";
            var MongoPot = "27017";
            var MongoHost = "localhost";
            var credential = MongoCredential.CreateCredential
                (MongoDatabaseName, MongoUsername, Mongopassword);
            var settings = new MongoClientSettings
            {
                Credentials = new[] { credential },
                Server = new MongoServerAddress(MongoHost, Convert.ToInt32(MongoPot))
            };
            _client = new MongoClient(settings);
            _server = _client.GetServer();
            _database = _server.GetDatabase(MongoDatabaseName);
        }
    }
}
