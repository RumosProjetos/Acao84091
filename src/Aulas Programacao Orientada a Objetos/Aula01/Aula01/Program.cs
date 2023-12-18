// See https://aka.ms/new-console-template for more information
using MeuPrimeiroProjeto.BusinessLogicLayer;

Console.WriteLine("Hello, World!");

int comando = 0;


Class1 minhaClasse = new Class1();
minhaClasse.MeuMetodo();

//TDD - Test Driven Development

comando = int.Parse(Console.ReadLine());

if(comando == 1)
{
    File.WriteAllText(@"c:\temp\exemplo.txt", "Aula 01");
}