using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrotas.ModeloDados.Entidades
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
            Ativo = true;
        }
    }
}
