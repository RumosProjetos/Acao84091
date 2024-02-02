// See https://aka.ms/new-console-template for more information
using IntroducaoAoMongoDB.Modelo;
using MongoDB.Bson;
using System.Text.Json;
//using MongoDB.Bson;
//using MongoDB.Driver;

Console.WriteLine("Hello, World!");


Postagem primeira = new Postagem();
primeira.Id = Guid.NewGuid();
primeira.Titulo = "Minha segunda Postagem";
primeira.Conteudo = "Conteúdo da postagem";

primeira.Imagens = new List<byte[]>();

byte[] peixe1 = File.ReadAllBytes(@".\Imagem\peixe1.jpg");
primeira.Imagens.Add(peixe1);

byte[] peixe2 = File.ReadAllBytes(@".\Imagem\peixe2.jpg");
primeira.Imagens.Add(peixe2);


primeira.Comentarios = new List<Comentario>();
primeira.Comentarios.Add(new Comentario
{
    Id = Guid.NewGuid(),
    EmailComentarista = "jose@sapo.pt",
    DataEHora = DateTime.Now,
    Texto = "Ok, gostei da postagem"
});
primeira.Comentarios.Add(new Comentario
{
    Id = Guid.NewGuid(),
    EmailComentarista = "marta@sapo.pt",
    DataEHora = DateTime.Now,
    Texto = "Eca, não gostei da postagem"
});
primeira.Comentarios.Add(new Comentario
{
    Id = Guid.NewGuid(),
    EmailComentarista = "paulo@sapo.pt",
    DataEHora = DateTime.Now,
    Texto = "Eca, não gostei da postagem"
});
primeira.Comentarios.Add(new Comentario
{
    Id = Guid.NewGuid(),
    EmailComentarista = "pedro@sapo.pt",
    DataEHora = DateTime.Now,
    Texto = "Eca, não gostei da postagem"
});

string meuJson = JsonSerializer.Serialize(primeira);

File.WriteAllText(@$"c:\temp\postagem2.txt", meuJson);




//var saida =  new BsonDocument("_id", new ObjectId("65bd5c687a0caac1e84aa91f"));