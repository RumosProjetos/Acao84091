﻿// See https://aka.ms/new-console-template for more information
using Exercicio01_ClassePessoa.Entidades;

Console.WriteLine("Hello, World!");


// Exemplo de uso da classe Pessoa
Pessoa pessoa1 = new Pessoa("João", 25);
pessoa1.ExibirInformacoes();
pessoa1.CalcularIdade(2012);

Pessoa pessoa2 = new Pessoa("Maria", 30);
pessoa2.ExibirInformacoes();
pessoa2.CalcularIdade(2012);