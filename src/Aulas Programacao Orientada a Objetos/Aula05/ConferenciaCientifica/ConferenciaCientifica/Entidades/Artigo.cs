using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Artigo
    {
        public string Titulo { get; set; }
        public string Abstract { get; set; }
        public Palestrante Palestrante { get; set; }
        public List<Autor> Autores { get; set; }
        //...
    }
}
