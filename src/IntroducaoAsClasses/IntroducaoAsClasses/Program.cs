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

Pessoa mariaDoCarmo = new Pessoa
{
    Nome = "Maria do Carmo",
    DataNascimento = new DateTime(1980, 01, 01)
};
Console.WriteLine("O NIF da MC é: " + mariaDoCarmo.NumeroContribuinte);



