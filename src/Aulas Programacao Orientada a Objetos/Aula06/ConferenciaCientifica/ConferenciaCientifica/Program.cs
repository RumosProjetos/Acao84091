using ConferenciaCientifica.Entidades;
using ConferenciaCientifica.Tradutores;

Console.WriteLine("Palestra sobre Física Quântica");

Autor autor = new Autor();
autor.Nome = "Isaac Newton";
autor.Especialidade = "Física Newtoniana";
autor.Filiacao = "Oxford";

Palestrante palestrante = new Palestrante();
palestrante.Nome = "Stephen Hawking";

Avaliador avaliador = new Avaliador();
avaliador.Nome = "Albert Einstein";



Artigo artigo = new Artigo();
artigo.Titulo = "Teoria das Cordas";
artigo.Autores = new List<Autor> { autor };


Palestra palestra = new Palestra();
palestra.Artigo = artigo;
palestra.Palestrante = palestrante;
palestra.Avaliadores = new List<Avaliador> { avaliador };


Expectador expectador = new Expectador();
expectador.Nome = "Aluno 01";

Expectador expectador2 = new Expectador();
expectador2.Nome = "Aluno 02";

Expectador expectador3 = new Expectador();
expectador3.Nome = "Aluno 03";

expectador3.TomarNotas("anotacoes");

avaliador.Avaliar();

autor.EscreverArtigo();
autor.EntregarArtigo();


string resultado = ConvertToEnglish.Translate("O rato roeu a roupa do rei");
Console.WriteLine(resultado);

artigo.Exemplo = 1;