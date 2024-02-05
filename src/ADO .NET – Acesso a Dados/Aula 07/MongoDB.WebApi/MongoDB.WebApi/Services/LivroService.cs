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
            MongoClient client = new MongoClient(livrariaDatabaseSettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(livrariaDatabaseSettings.Value.DatabaseName);
            _livroCollection = database.GetCollection<Livro>(livrariaDatabaseSettings.Value.LivrosCollectionName);
        }

        public List<Livro> Livros => _livroCollection.Find(_ => true).ToList();
        public Livro Obter(string id) => _livroCollection.Find(x => x.Id == id).FirstOrDefault();

        public void CriarLivro(Livro livro) => _livroCollection.InsertOne(livro);

        public void AtualizarLivro(string id, Livro livro) => _livroCollection.ReplaceOne(x => x.Id == id, livro);
        
        public void ApagarLivro(string id) => _livroCollection.DeleteOne(x => x.Id == id);
    }
}
