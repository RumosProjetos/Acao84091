using GestaoFrotas.ConsoleApp.Constantes;
using GestaoFrotas.ConsoleApp.ModuloOperacional;

namespace GestaoFrotas.ConsoleApp.ModuloInicial
{
    public class TelaOperacoes
    {
        public TelaOperacoes()
        {
            Console.WriteLine($"Escolha a opção:");
            Console.WriteLine($"C - Para Cliente");
            Console.WriteLine($"A - Para Automóvel");

            string operacao = Console.ReadLine();
    
            if ( operacao == Sistema.TeclaTelaCliente)
            {
                TelaCliente telaCliente = new TelaCliente();
            }

            if (operacao == Sistema.TeclaTelaAutomovel)
            {
                //Automovel
            }
        }
    }
}
