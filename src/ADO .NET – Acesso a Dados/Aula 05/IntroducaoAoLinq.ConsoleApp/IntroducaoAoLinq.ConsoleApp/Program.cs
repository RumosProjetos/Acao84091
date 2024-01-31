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


Console.WriteLine($"A foto com mais comentários foi: {fotosComMaisComentarios.Titulo}");

//Qual fotógrafo teve mais comentários nas fotos
//Qual foi o fotografo que teve mais fotos