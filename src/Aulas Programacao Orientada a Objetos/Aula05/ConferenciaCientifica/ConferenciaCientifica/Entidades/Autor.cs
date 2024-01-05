using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Autor : Pessoa
    {
        public string Especialidade { get; set; }
        public string Filiacao { get; set; }
    }
}
