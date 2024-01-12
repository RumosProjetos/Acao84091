using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFrotas.ModeloDados.Entidades
{
    public class Locacao
    {
        public Cliente? Cliente { get; set; }
        public Automovel? Automovel { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo => DataInicio <= DateTime.Now && DataFim >= DateTime.Now;
    }
}
