using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrotas.ConsoleApp.ModuloInicial
{
    public class TelaBoasVindas
    {
        public TelaBoasVindas()
        {
            string mensagem = "Boa tarde";
            if(DateTime.Now.Hour > 6 && DateTime.Now.Hour < 12)
            {
                mensagem = "Bom dia";
            }

            Console.WriteLine($"{mensagem}");

            Console.WriteLine($"Escolha a opção:");
            Console.WriteLine($"L - Para Logar");
            Console.WriteLine($"X - Para Sair");
        }
    }
}
