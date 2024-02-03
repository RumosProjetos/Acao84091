using MongoDB.Crud.Modelo;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB.ConsoleCrud.Servicos
{
    public class FamilyService
    {
        private readonly MongoClient _client;
        private readonly IMongoCollection<Family> _familyCollection;

        public FamilyService()
        {
            string connectionString = @"mongodb://mongodbjaon:E1bUoIG855npAjhkb4CxSPYTS8DjA2uScfd20qKecPjl2oSrChAXfmwaLiCgv3MtvXvijbH83X29ACDb9zJpxQ==@mongodbjaon.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@mongodbjaon@";
            MongoClientSettings settings = MongoClientSettings.FromUrl(
                new MongoUrl(connectionString)
            );
            settings.SslSettings = new SslSettings() { EnabledSslProtocols = SslProtocols.Tls12 };
            _client = new MongoClient(settings);

            var mongoDatabase = _client.GetDatabase("CosmosDBTutorial");
            _familyCollection = mongoDatabase.GetCollection<Family>("Family");
        }

        public List<string> ObterDatabaseNames() => _client.ListDatabaseNames().ToList();
        public List<Family> Obter() => _familyCollection.Find(_ => true).ToList();
        public Family? ObterPorId(string id) => _familyCollection.Find(x => x.Id == id).FirstOrDefault();
        public void CriarNovo(Family newFamily) => _familyCollection.InsertOne(newFamily);
        public void Atualizar(string id, Family updatedFamily) => _familyCollection.ReplaceOne(x => x.Id == id, updatedFamily);
        public void Apagar(string id) => _familyCollection.DeleteOne(x => x.Id == id);
    }
}
