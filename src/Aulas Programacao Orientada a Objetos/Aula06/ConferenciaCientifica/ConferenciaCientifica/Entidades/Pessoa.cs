using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal abstract class Pessoa
    {
        public string Nome { get; set; }

        public void RealizarInscricao()
        {
            int minhaInscricao = new Random().Next(0, 100);

            //Exemplo forma antiga
            //Console.WriteLine("Inscrição " + minhaInscricao + " foi gerada");

            //Exemplo C# 6 em diante
            Console.WriteLine($"Inscrição {minhaInscricao} foi gerada");
        }
    }
}
