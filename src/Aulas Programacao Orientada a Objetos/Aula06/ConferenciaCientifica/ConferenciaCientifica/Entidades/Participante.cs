using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal abstract class Participante : Pessoa
    {
        public string Especialidade { get; set; }
        public string Filiacao { get; set; }
    }
}
