using DatabaseFirstDotnetCore.ConsoleApp.CamadaAcessoDados;
using DatabaseFirstDotnetCore.ConsoleApp.Modelo;
using StackExchange.Profiling;


var repositorio = new PessoaRepository();

//List<Pessoa> pessoas = repositorio.ObterTodos();
//List<Pessoa> pessoas = repositorio.ObterTodosPorEspecialidade("Engenheiro");
List<Pessoa> pessoas = repositorio.ObterTodosComEspecialidade();

foreach (var p in pessoas)
{
    Console.WriteLine($"Encontrei a pessoa {p.Nome} especialista em {p.Especialidade}");
}


Pessoa pessoa = new Pessoa();
pessoa.Nome = "Zé da Silva";
pessoa.Especialidade = "Escritor";
pessoa.Participacao = "Autor";


//repositorio.CriarNovo(pessoa);

//if(repositorio.Atualizar(1, pessoa))
//{
//    Console.WriteLine($"Atualizei a {pessoa.Nome}");
//}
//else
//{
//    Console.WriteLine($"{pessoa.Nome} não encontrada");
//}

Pessoa pessoa2 = repositorio.ObterPorId(20);
if (pessoa2 != null)
{
    if (repositorio.ApagarPorId(pessoa2.Id))
    {
        Console.WriteLine($"Apaguei a pessoa {pessoa2.Nome}");
    }
    else
    {
        Console.WriteLine($"{pessoa2.Nome} não encontrada");
    }

}




