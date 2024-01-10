using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcesso.Entidades
{
    internal class Pessoa
    {
        #region Construtores
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
        #endregion Construtores

        #region Propriedades
        public string Nome { get; set; }
        private DateTime DataNascimento { get; set; }
        #endregion Propriedades

        #region Métodos Públicos

        public void Falar()
        {
            Console.WriteLine($"Oi Mundo, eu sou {Nome} e nasci no dia {DataNascimento}");
        }

        protected void Escutar()
        {
            Console.WriteLine($"Escutei meu nome");
            MeuMetodoPrivado();
        }

        public static void MeuMetodoEstatico()
        {
            Console.WriteLine("Oi sou o método estático da classe Pessoa");
        }
        #endregion Métodos Públicos

        #region Métodos Privados
        private void MeuMetodoPrivado()
        {
            Console.WriteLine("Método privado foi invocado");
        }
        #endregion Métodos Privados
    }
}

//public - Todos podem acessar
//protected - Apenas as classes filhas
//private - Apenas a própria classe
//internal == package (qualquer classe do mesmo namespace)
//sealed == final - classe terminal