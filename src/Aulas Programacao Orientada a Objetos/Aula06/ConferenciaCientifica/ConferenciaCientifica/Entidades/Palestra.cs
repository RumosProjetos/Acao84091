using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Palestra
    {
        public Palestrante Palestrante { get; set; }   
        public Artigo Artigo { get; set; }
        public DateTime? DataEHora { get; set; }
        public List<Avaliador> Avaliadores { get; set; }
    }
}
