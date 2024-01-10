using ModificadoresAcesso.Entidades;
using ModificadoresAcesso.Utilitarios;

Pessoa maria = new Pessoa("Maria");
maria.Falar();
maria.DataNascimento = new DateTime(2000, 01, 01);
Pessoa.MeuMetodoEstatico();


Estatica.MeuValor = "batata";
string valorLocal = Estatica.ConverterParaMaiusculas();
Console.WriteLine(valorLocal);