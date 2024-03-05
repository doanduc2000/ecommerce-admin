using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceAdmin.Help
{
    public class MongoDBHelper
    {
        private MongoClient client;
        private IMongoDatabase database;
        
        public MongoDBHelper()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("ecommerce");
        }

        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return database.GetCollection<T>(collectionName);
        }
        public void InsertData<T>(string collectionName, T data) {
            var collection = database.GetCollection<T>(collectionName);
            collection.InsertOne(data);
        }
        public void DeleteData<T>(string collectionName, Dictionary<string, object> filter)
        {
            var collection = database.GetCollection<T>(collectionName);
            var bsonFilter = new BsonDocument(filter);
            collection.DeleteOne(bsonFilter);
        }
        public void UpdateData<T>(string collectionName, FilterDefinition<T> filter, UpdateDefinition<T> update)
        {
            var collection = database.GetCollection<T>(collectionName);
            collection.UpdateOne(filter, update);
        }
    }
}
