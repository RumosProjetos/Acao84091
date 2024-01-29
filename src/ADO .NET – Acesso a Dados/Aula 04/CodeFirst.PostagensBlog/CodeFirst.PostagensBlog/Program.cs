// See https://aka.ms/new-console-template for more information
using CodeFirst.PostagensBlog.AcessoDados;
using CodeFirst.PostagensBlog.Modelo;

Console.WriteLine("Hello, World!");


Postagem postagem = new Postagem();
postagem.Titulo = "Postagem Nova";
postagem.Conteudo = "lorem ipsum, lorem ipsum, lorem ipsum, lorem ipsum, lorem ipsum, lorem ipsum,  ";

Comentarista comentarista = new Comentarista();
comentarista.Nome = "Amigo";
comentarista.EmailComentarista = "gajofixe@sapo.pt";
comentarista.Ativo = true;

Comentario comentario = new Comentario();
comentario.DataEHora = DateTime.Now;
comentario.Comentarista = comentarista;
comentario.Texto = "Esse post ficou ótimo";
postagem.Comentarios.Add(comentario);


PostagemContext db = new PostagemContext();
db.Postagens.Add(postagem);
db.Comentaristas.Add(comentarista);
db.Comentarios.Add(comentario);

db.SaveChanges();


//Buscar a primeira postagem com os 10 primeiros comentarios
/*
 SELECT p.Titulo, g.Nome, c.Texto
FROM  Postagens p
LEFT JOIN Comentarios c ON c.PostagemId = p.Id
LEFT JOIN Comentaristas g ON g.Id = c.ComentaristaId

 */

var resultado = (from p in db.Postagens
                select new
                {
                    p.Titulo,
                    p.Comentarios.FirstOrDefault().Comentarista.Nome,
                    p.Comentarios.FirstOrDefault().Texto
                }).FirstOrDefault();

Console.WriteLine($"Postagem: {resultado.Titulo}, Comentarista: {resultado.Nome}, Texto: {resultado.Texto}");