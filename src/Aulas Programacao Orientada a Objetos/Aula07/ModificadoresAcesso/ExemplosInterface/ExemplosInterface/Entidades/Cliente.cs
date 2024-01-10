using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosInterface.Entidades
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public List<ContaCorrente> contaCorrentes { get; set; }
    }
}
