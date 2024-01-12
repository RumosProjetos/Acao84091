using GestaoFrotas.LogicaNegocio.Interfaces;
using GestaoFrotas.ModeloDados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrotas.LogicaNegocio.Logica
{
    public class UsuarioManager : IOperacao<Usuario>
    {
        private readonly List<Usuario> usuarios;
        public UsuarioManager()
        {
            //Deveria ter vindo do Database
            usuarios = new List<Usuario>();
            usuarios.Add(new Usuario("maria", "maria123"));
            usuarios.Add(new Usuario("pedro", "pedro123"));
            usuarios.Add(new Usuario("joao", "joao123"));
        }

        public List<Usuario> Adicionar(Usuario item)
        {
            usuarios.Add(item);
            return usuarios;
        }

        public Usuario Atualizar(string identificador, Usuario dadosNovos)
        {
            Usuario usuario = Localizar(identificador);
            usuario.Ativo = dadosNovos.Ativo;
            //usuario.Login = usuario.Login; //Como usamos o Login como identificador, não pode ser alterado
            usuario.Senha = usuario.Senha;

            return usuario;
        }

        public Usuario Desativar(string identificador)
        {
            Usuario usuario = Localizar(identificador);
            usuario.Ativo = false;

            return usuario;
        }

        public Usuario Localizar(string identificador)
        {
            foreach (var item in usuarios)
            {
                if (item.Login == identificador)
                {
                    return item;
                }
            }

            return null;
        }

        public List<Usuario> MostrarTodos()
        {
            return usuarios;
        }
    }
}
