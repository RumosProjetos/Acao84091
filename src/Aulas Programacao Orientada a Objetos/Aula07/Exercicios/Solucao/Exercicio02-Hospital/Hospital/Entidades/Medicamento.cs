using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Entidades
{
    public class Medicamento
    {
        public string Nome { get; set; }
        public string Dosagem { get; set; }
        public string ModoPreparo { get; set; }
        public List<string> PrincipioAtivo { get; set; }
        public int Unidades { get; set; }
        public DateTime DataValidade { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Lote { get; set; }
    }
}
