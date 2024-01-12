using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrotas.ModeloDados.Entidades
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public string? CartaConducao { get; set; }
        public bool Ativo { get; set; }

        public Cliente(string nome, string cartaConducao)
        {
            Nome = nome;
            CartaConducao = cartaConducao;
            Ativo = true;
        }
    }
}
