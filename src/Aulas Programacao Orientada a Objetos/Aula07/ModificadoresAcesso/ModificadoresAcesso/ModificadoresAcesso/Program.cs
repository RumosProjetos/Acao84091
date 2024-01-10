using ModificadoresAcesso.Entidades;
using ModificadoresAcesso.Utilitarios;

Pessoa maria = new Pessoa("Maria");
maria.MeuMetodoPublico();


//maria.DataNascimento = new DateTime(2000, 01, 01);
Pessoa.MeuMetodoEstatico();


var joao = new Pessoa("João da Silva");
Pessoa pedro = new("Pedro Carlos");


Estatica.MeuValor = "batata";
string valorLocal = Estatica.ConverterParaMaiusculas();
Console.WriteLine(valorLocal);


/*
+ adicao
- subtracao
/ divisao
* multiplicacao
% resto da divisao
= atribuicao
== igualdade
! negacao
&& E lógico
|| Ou lógico
^ Ou exclusivo
 */


Console.WriteLine(1 + 1);//Somar
Console.WriteLine("Maria" + " da Silva");//Concatenar

Pessoa joaoMaria = maria + joao;
Console.WriteLine(joaoMaria.Nome);

//Validar se Maria e João são a mesma pessoa
if(maria == joao)
{
    Console.WriteLine("Dados Duplicados");
}
else
{
    Console.WriteLine("Pessoas diferentes");
}