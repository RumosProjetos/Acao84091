using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcesso.Entidades
{
    sealed internal class Paciente : Pessoa
    {
        public Paciente(string nome) : base(nome)
        {
            Nome = nome;
            Escutar();
        }

    }
}
