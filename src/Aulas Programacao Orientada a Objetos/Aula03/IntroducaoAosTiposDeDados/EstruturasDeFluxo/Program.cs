// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Reflection.PortableExecutable;

Console.WriteLine("Hello, World!");


//if
//else
//else if

var idade = 18;
var idadeMaxima = 65;

if (idade >= 18)
{
    Console.WriteLine("Pode entrar");

    if(idade >= idadeMaxima)
    {
        Console.WriteLine("Não paga bilhete");
    }
}
else
{
    Console.WriteLine("Não pode entrar");
}


//switch
int DiaDaSemana = 3;

switch (DiaDaSemana)
{
    case 0:
        Console.WriteLine("Domingo");
        break;
    case 1:
        Console.WriteLine("Segunda");
        break;
    default:
        break;
}

//Loops
for(int i = 0; i < 100; i++)
{
    Console.WriteLine("Devo praticar o código");
}

int contador = 0;

while (contador < 10)
{
    Console.WriteLine("Devo praticar o código");
    contador++;
}

do{
    Console.WriteLine("Devo praticar o código");
    contador++;
} while (contador < 10);