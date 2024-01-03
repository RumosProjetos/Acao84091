// See https://aka.ms/new-console-template for more information
using ApoioAoAprendizado;
using System.Collections;

Console.WriteLine("Hello, World!");

var tiago = new Pessoa();

tiago.Notas = new int[4];

tiago.Notas[0] = 20;
tiago.Notas[1] = 15;
tiago.Notas[2] = 18;
tiago.Notas[3] = 10;

foreach (var item in tiago.Notas)
{
    Console.WriteLine("A nota foi" + item);
}

Console.WriteLine(tiago.Notas[3]);


tiago.NotasPorDisciplina = new int[3, 4];
tiago.NotasPorDisciplina[0, 0] = 20;
tiago.NotasPorDisciplina[0, 1] = 15;
tiago.NotasPorDisciplina[0, 2] = 18;
tiago.NotasPorDisciplina[0, 3] = 10;

tiago.NotasPorDisciplina[1, 0] = 5;
tiago.NotasPorDisciplina[1, 1] = 10;
tiago.NotasPorDisciplina[1, 2] = 12;
tiago.NotasPorDisciplina[1, 3] = 15;


tiago.NotasPorDisciplina[2, 0] = 12;
tiago.NotasPorDisciplina[2, 1] = 20;
tiago.NotasPorDisciplina[2, 2] = 15;
tiago.NotasPorDisciplina[2, 3] = 18;

tiago.MusicasFavoritas = new List<string>();
tiago.MusicasFavoritas.Add("Sweet o' mine");
tiago.MusicasFavoritas.Add("Bohemian Rapsody");
tiago.MusicasFavoritas.Add("Pais e filhos");


var marta = new Pessoa();
marta.MusicasFavoritas = new List<string>();
marta.MusicasFavoritas.Add("Não aprendi a dizer adeus");
marta.MusicasFavoritas.Add("Vou chorar");
marta.MusicasFavoritas.RemoveAt(1);



///
///

var pessoaEspecial = new PessoaEspecial();


tiago = pessoaEspecial;

(tiago as PessoaEspecial).Nif = "11111";



int Idade = 0;
Int32 IdadeInt = 0;
var IdadeVar = 0;


Decimal exemploPercentual = 0.5M;

Pessoa joao = new Pessoa();
var Maria = new Pessoa();
Pessoa pedro = new();

if (pedro is Pessoa)
{

}


const decimal ValorAliquotaDoGoverno = 0.02M;

var valorFinal = exemploPercentual * ValorAliquotaDoGoverno;


int valorEntrada = 5;
switch (valorEntrada)
{
    case 1:
        Console.WriteLine("O valor é UM");
        break;
    case 2:
        Console.WriteLine("O valor é DOIS");
        break;
    case 3:
        Console.WriteLine("O valor é TRES");
        break;
    case 4:
        Console.WriteLine("O valor é QUATRO");
        break;
    case 5:
        Console.WriteLine("O valor é CINCO");
        break;
}


var diaDaSemana = DiasSemana.Quinta;

switch (diaDaSemana)
{
    case DiasSemana.Domingo:
        break;
    case DiasSemana.Segunda:
        break;
    case DiasSemana.Terca:
        break;
    case DiasSemana.Quarta:
        break;
    case DiasSemana.Quinta:
        break;
    case DiasSemana.Sexta:
        break;
    case DiasSemana.Sabado:
        break;
    default:
        break;
}

Cores minhaCorFavorita = new();

switch (minhaCorFavorita)
{
    case Cores.Azul:
        break;
    case Cores.Vermelho:
        break;
    case Cores.Verde:
        break;
}

if (2 == 2)
{
    Console.WriteLine("Verdadeiro");
}
else
{
    Console.WriteLine("Falso");
}


if (minhaCorFavorita == Cores.Azul)
{
    if (diaDaSemana == DiasSemana.Domingo)
    {
        Console.WriteLine("Bom dia, lindo domingo de céu azul");
    }
}

if (minhaCorFavorita == Cores.Azul && diaDaSemana == DiasSemana.Domingo)
{
    Console.WriteLine("Bom dia, lindo domingo de céu azul");
}

if (minhaCorFavorita != Cores.Verde) { }

bool MinhaCorFavoritaEhAzul = !(minhaCorFavorita == Cores.Azul);

//Ou comum, tanto faz se a primeira ou a segunda sentença são verdadeiras
if (minhaCorFavorita == Cores.Azul || minhaCorFavorita == Cores.Verde)
{
    //....
}


//Ou exclusivo: Ou uma coisa ou outra, se ambos forem verdadeiro, não faz
if (minhaCorFavorita == Cores.Azul ^ diaDaSemana == DiasSemana.Domingo)
{

}



int idade = 10;
idade = idade + 1;
idade += 1;

idade = idade - 1;
idade -= 1;



idade = idade * 10;
idade *= 10;

idade = idade / 10;
idade /= 10;



string[] frutas = { "Banana", "Maçã", "Uva", "Morango" };

Console.WriteLine("A primeira fruta é:" + frutas[1]);


//Ordem inserida
Console.WriteLine("Ordem inserida");
int[] numeros = { 0, 10, 40, 30, 20, 25 };
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

//Ordem invertida
Console.WriteLine("Ordem invertida");
var numerosInvertidos = numeros.Reverse();
foreach (int numero in numerosInvertidos)
{
    Console.WriteLine(numero);
}


//Ordem correta
Console.WriteLine("Ordem Correta");
var ordemCorreta = numeros.Order();
foreach (int numero in ordemCorreta)
{
    Console.WriteLine(numero);
}

//Ordem do menor para o maior
Console.WriteLine("Ordem do menor para o maior");
var ordemDoMaiorParaMenor = numeros.OrderDescending();
foreach (int numero in ordemDoMaiorParaMenor)
{
    Console.WriteLine(numero);
}


string[] nomes = { "Ana","Zélia", "José", "João", "Daniel", "Carlos" };
var nomesOrdenados = nomes.Order();
foreach (var nome in nomesOrdenados)
{
    Console.WriteLine(nome);
}

Pessoa[] pessoas = new Pessoa[10];
pessoas[0] = tiago;
pessoas[0].Idade = 10;



Tabuada tab = new Tabuada(13);
tab.Calcular();

Console.WriteLine(tab.ValoresCalculados[7]);




//Coleção:
//Fila - Queue
// 1 entra é o primeiro que sai
List<Pessoa> pessoas1 = new List<Pessoa>();
pessoas1.Add(tiago);
pessoas1.Add(Maria);
pessoas1.Add(marta);
pessoas1.Add(joao);
//... 

//foreach (var item in pessoas1)
//{
//    if (item.Nome.StartsWith("M"))
//    {
//        //
//    }

//}

//pessoas1.Where(item => item.Nome.StartsWith("M"));




List<object> minhaLista = new List<object>();
minhaLista.Add(tiago);
minhaLista.Add(1);
minhaLista.Add("minha string");
minhaLista.Add(DateTime.Now);




foreach (var item in minhaLista)
{
    if(item is Pessoa)
    {
        //
    }
    if(item is string) { }

    if (item is Int32) { }
}


//foreach (var item in minhaLista)
//{
//   switch(item.GetType()) {
//        case typeof(string):
//            break;
//    }
//}


List<Pessoa> pessoasGenerico = new List<Pessoa>();
pessoasGenerico.Add(tiago);
tiago.Nome = "Tiago da Silva";


PessoaColetiva minhaEmpresaSa = new PessoaColetiva();
minhaEmpresaSa.Idade = 20;
minhaEmpresaSa.Nome = "Minha multinacional";

pessoasGenerico.Add(minhaEmpresaSa);


foreach (var item in pessoasGenerico)
{
    Console.WriteLine("A idade da pessoa" + item.Nome + " é " + item.Idade);
}
