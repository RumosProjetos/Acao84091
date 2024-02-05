using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.WebApi.Models;

namespace MongoDB.WebApi.Services
{
    public class LivroService
    {
        private readonly IMongoCollection<Livro> _livroCollection;

        public LivroService(IOptions<LivrariaDatabaseSettings> livrariaDatabaseSettings)
        {
            var client = new MongoClient(livrariaDatabaseSettings.Value.ConnectionString);
            var database = client.GetDatabase(livrariaDatabaseSettings.Value.DatabaseName);
            _livroCollection = database.GetCollection<Livro>(livrariaDatabaseSettings.Value.LivrosCollectionName);
        }
    }
}
