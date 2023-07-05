using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace mongo_test
{
    class Program
    {
        static void Main(string[] args)
        {
            const string connectionUri = "mongodb+srv://makoto:ae21215926@cluster0.zihxmz9.mongodb.net/?retryWrites=true&w=majority";

            var settings = MongoClientSettings.FromConnectionString(connectionUri);

            var client = new MongoClient(settings);
            var db = client.GetDatabase("test");
            var collection = db.GetCollection<BsonDocument>("test1");
            var result = collection.Find("{ID:1}").FirstOrDefault();
            Console.WriteLine(result["text"]);

        }
    }
}



