using Amazon.Runtime.Documents;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdParty.Json.LitJson;

namespace Negocio
{
    internal class Connection
    {
        public void insertData(BsonDocument document) {
            MongoClient dbClient = new MongoClient("mongodb+srv://EurisAquino:AvjsQVEU2w38B1tY@cluster0.nu42xpp.mongodb.net/");

            var database = dbClient.GetDatabase("Negocio");
            var collection = database.GetCollection<BsonDocument>("Clientes");

            collection.InsertOne(document);
        }
    }
}
