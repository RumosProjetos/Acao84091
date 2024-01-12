using GestaoFrotas.LogicaNegocio.Interfaces;
using GestaoFrotas.ModeloDados.Entidades;

namespace GestaoFrotas.LogicaNegocio.Logica
{
    public class ClienteManager : IOperacao<Cliente>
    {
        List<Cliente> clientes;
        public ClienteManager()
        {
            clientes = new List<Cliente>();
            clientes.Add(new Cliente("Jose", "1111"));
            clientes.Add(new Cliente("Maria", "2222"));
            clientes.Add(new Cliente("Marta", "3333"));
        }

        public List<Cliente> Adicionar(Cliente item)
        {
            clientes.Add(item);
            return clientes;
        }

        public Cliente Atualizar(string identificador, Cliente dadosNovos)
        {
            Cliente cliente = Localizar(identificador);
            cliente.Ativo = dadosNovos.Ativo;            
            cliente.CartaConducao = cliente.CartaConducao;
            //cliente.Nome = cliente.Nome; // Não vai acontecer porque é o identificador

            return cliente;
        }

        public Cliente Desativar(string identificador)
        {
            Cliente cliente = Localizar(identificador);
            cliente.Ativo = false;

            return cliente;
        }

        public Cliente Localizar(string identificador)
        {
            foreach (var item in clientes)
            {
                if (item.Nome == identificador)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
