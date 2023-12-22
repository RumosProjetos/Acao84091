// See https://aka.ms/new-console-template for more information
using IntroducaoAsClasses;

Console.WriteLine("Hello, World!");


Pessoa joaoDasCouves = new Pessoa();
joaoDasCouves.Nome = "João Pereira das Couves";
joaoDasCouves.DataNascimento = new DateTime(2000, 01, 01);
joaoDasCouves.NumeroContribuinte = "123456789";


joaoDasCouves.Endereco = new Endereco();
joaoDasCouves.Endereco.Morada = "Rua das Casas";

Console.WriteLine("O NIF do JC é: " + joaoDasCouves.NumeroContribuinte);
Console.WriteLine("A Morada do JC é: " + joaoDasCouves.Endereco.Morada);



joaoDasCouves.NomeCompleto = "joao das couves";
Console.WriteLine("O Nome do Joao é: " + joaoDasCouves.NomeCompleto);
string dadosDoJoao = joaoDasCouves.ListarPropriedades();
Console.WriteLine(dadosDoJoao);
joaoDasCouves.Imprimir("asdasdas");


//string minhaStringVazia = "";

string minhaStringNula = null;

/*
 Meu comentário super complicado
 Com várias linhas
 */


Pessoa mariaDoCarmo = new Pessoa
{
    Nome = "Maria do Carmo",
    DataNascimento = new DateTime(1980, 01, 01)
};
Console.WriteLine("O NIF da MC é: " + mariaDoCarmo.NumeroContribuinte);





Pessoa.ImprimirClasse();

mariaDoCarmo.Imprimir("sdsdf");


Pessoa mariaAntonia = new Pessoa(); //1.0
Console.WriteLine(mariaAntonia.Nome);


var mariaPereira = new Pessoa("Maria Pereira"); //3.0
Console.WriteLine(mariaPereira.Nome);


Pessoa mariaAntonieta = new(); //4.6 ... core


