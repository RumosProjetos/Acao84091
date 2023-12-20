using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoAsClasses
{
    internal class Pessoa
    {
        public string? Nome { get; set; }
        private DateTime dataNascimento;
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string? NumeroContribuinte { get; set; }        
        public DateTime DataCriacao => DateTime.Now;
        public bool EstaAtivo { get; }

        public Endereco? Endereco { get; set; }
    }
}