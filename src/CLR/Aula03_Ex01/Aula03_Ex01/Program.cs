using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valor = ConfigurationManager.AppSettings["minhaConfiguracao"];
            Console.WriteLine("Oi mundo, versão 4.8");
            Console.WriteLine("====================");
            Console.WriteLine("Valor da configuração: " + valor);
            Console.ReadLine();


            //Tipos primitivos - CPS
            int i = 10;
            Int32 j = 10;
            char c = 'a';
            Char d = 'a';
            bool simnao = true;
            Boolean simnao2 = true;
            Byte b = 10;
            float f = 10.5f;
            double d2 = 10.5;

            int[] vetor = new int[10];

            //Tipos por referência
            string nome = "João";
            decimal valor2 = 10.5m;

        }
    }
}
