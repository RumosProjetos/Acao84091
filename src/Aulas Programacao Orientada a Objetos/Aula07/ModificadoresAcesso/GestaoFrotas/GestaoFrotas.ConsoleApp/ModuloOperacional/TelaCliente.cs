using GestaoFrotas.LogicaNegocio.Logica;
using GestaoFrotas.ModeloDados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrotas.ConsoleApp.ModuloOperacional
{
    public class TelaCliente
    {
        ClienteManager clienteManager;

        public TelaCliente()
        {
            Console.WriteLine($"Escolha a opção:");
            Console.WriteLine($"Ad - Para Adicionar Cliente");
            Console.WriteLine($"At - Para Atualizar Cliente");
            Console.WriteLine($"D - Para Desativar Cliente");
            Console.WriteLine($"L - Para Localizar Cliente");
            Console.WriteLine($"T - Para Mostrar Todos os Cliente");

            string operacao = Console.ReadLine();
            clienteManager = new ClienteManager();

            if (operacao == "T")
            {
                MostrarTodos();
            }
        }

        public void MostrarTodos()
        {
            List<Cliente> clientes = clienteManager.MostrarTodos();
            foreach (Cliente cliente in clientes)
            {
                if(cliente.Ativo)
                {
                    Console.WriteLine($"Cliente: {cliente.Nome}");
                    Console.WriteLine($"Carta de Condução: {cliente.CartaConducao}");
                }                
            }
        }
    }
}
