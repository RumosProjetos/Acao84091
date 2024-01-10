using System;

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

        public void MeuMetodoPublico()
        {
            Console.WriteLine($"Oi Mundo, eu sou {Nome} e nasci no dia {DataNascimento}");
        }

        protected void MeuMetodoProtegido()
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


        public static Pessoa operator +(Pessoa p1, Pessoa p2)
        {
            Pessoa resultado = new Pessoa(p1.Nome + p2.Nome);
            return resultado;
        }

        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            return p1.Nome == p2.Nome && p1.DataNascimento == p2.DataNascimento;
        }

        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return !(p1 == p2);
        }
    }
}

//public - Todos podem acessar
//protected - Apenas as classes filhas
//private - Apenas a própria classe
//internal == package (qualquer classe do mesmo namespace)
//sealed == final - classe terminal