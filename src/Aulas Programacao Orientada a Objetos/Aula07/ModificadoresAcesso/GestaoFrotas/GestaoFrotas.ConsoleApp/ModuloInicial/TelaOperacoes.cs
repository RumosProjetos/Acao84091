using GestaoFrotas.ConsoleApp.Constantes;

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
                //Cliente
            }

            if (operacao == Sistema.TeclaTelaAutomovel)
            {
                //Automovel
            }
        }
    }
}
