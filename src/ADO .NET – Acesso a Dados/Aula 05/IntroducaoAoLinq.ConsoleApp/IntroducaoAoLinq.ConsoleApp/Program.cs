// See https://aka.ms/new-console-template for more information
using IntroducaoAoLinq.ConsoleApp.Builder;
using IntroducaoAoLinq.ConsoleApp.Modelo;

Console.WriteLine("Hello, World!");


int[] meuarray = {1, 2, 3, 4, 5 };

var teste = meuarray.Where(x => x <= 3).Select(x => x);

foreach (var test in teste)
{
    Console.Write(test + ", ");
}


string[] arrayStrings = { "José", "Antônio", "João", "Márcio Soares",
                          "Jônatas", "Priscila",
                          "Ricardo", "Miguel", "Márcio Melo"};


string[] arrayordenado = arrayStrings.OrderBy(x => x).ToArray();

foreach (var test in arrayordenado) {
    Console.WriteLine(test + ", ");
}



string[] arrayordenadoinverso = arrayStrings.OrderByDescending(x => x).ToArray();

foreach (var test in arrayordenadoinverso)
{
    Console.WriteLine(test + ", ");
}


FotoBuilder fb = new FotoBuilder();
var local = fb.Fotos;


//Qual é a foto mais antiga
var fotoMaisAntiga = (from foto in fb.Fotos
                     orderby foto.DataCriacao
                     select foto)
                     .FirstOrDefault();

var fotoMaisAntigaLambda = fb.Fotos.OrderBy(foto => foto.DataCriacao)
                           .FirstOrDefault();

Console.WriteLine($"A foto mais antiga é {fotoMaisAntiga.Titulo}");

//Qual é a maior fotografia
var maiorFotografia = (from foto in fb.Fotos
                      orderby foto.ArquivoFoto.Length descending
                      select foto)
                      .FirstOrDefault();

var maiorFotografiaLambda = fb.Fotos.OrderByDescending(foto => foto.ArquivoFoto.Length)
                           .FirstOrDefault();

Console.WriteLine($"A maior fotografia é {maiorFotografiaLambda.Titulo}");

//Quantos comentarios tem cada foto?
var contagemComentarios = (from foto in fb.Fotos
                           select new { foto.Titulo, foto.Comentarios.Count });

var contagemComentariosLambda = fb.Fotos
                          .Select(foto => new { foto.Titulo, foto.Comentarios.Count });

Console.WriteLine(contagemComentarios);


//Qual foto tem mais comentários
var fotosComMaisComentarios = (from foto in fb.Fotos
                               orderby foto.Comentarios.Count descending
                           select new { foto.Titulo, foto.Comentarios.Count })
                           .FirstOrDefault();

int[] numeros = { 7, 40, 3, 34, 3 };
var maximo = numeros.Max(x => x);
Console.WriteLine(maximo);


var fotosComMaisComentariosGroupby = ((from foto in fb.Fotos
                                       group foto by foto.Titulo into gr
                                       orderby gr.Max(p => p.Comentarios.Count) descending
                                       select (Titulo: gr.Key,
                                                 MaximoContagemComentarios: gr.Max(p => p.Comentarios.Count))
                                                )).FirstOrDefault();

/*
SELECT f.Titulo, Max(c.comentarios)
From foto f
left join comentario c on f.id = comentario.fotoid
group by f.titulo
having count(c.comentarios) = max(c.comentarios)
*/



Console.WriteLine($"A foto com mais comentários foi: {fotosComMaisComentarios.Titulo}, {fotosComMaisComentarios.Count} com comentarios");

//Qual fotógrafo teve mais comentários nas fotos
var fotografoComMaisComentarios = ((from foto in fb.Fotos
                                    group foto by foto.Fotografo into gr
                                    orderby gr.Sum(p => p.Comentarios.Count) descending
                                    select (Fotografo: gr.Key,
                                              MaximoContagemComentarios: gr.Sum(p => p.Comentarios.Count))
                                                )).FirstOrDefault();

Console.WriteLine($"O fotógrafo com mais comentários foi: {fotografoComMaisComentarios.Fotografo} " +
                  $"com {fotografoComMaisComentarios.MaximoContagemComentarios} comentarios");


//Qual foi o fotografo que teve mais fotos
var fotografoComMaisFotos = ((from foto in fb.Fotos
                                    group foto by foto.Fotografo into gr
                                    orderby gr.Count() descending, gr.Key                                    
                                    select (Fotografo: gr.Key,
                                              ContagemFotos: gr.Count())
                                                )).FirstOrDefault();

Console.WriteLine($"O fotógrafo mais fotografador foi {fotografoComMaisFotos.Fotografo} com {fotografoComMaisFotos.ContagemFotos} fotos");