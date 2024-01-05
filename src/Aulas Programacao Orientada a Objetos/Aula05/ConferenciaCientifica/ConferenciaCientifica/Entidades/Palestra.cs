using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Palestra
    {
        Palestrante Palestrante { get; set; }   
        Artigo Artigo { get; set; }
        DateTime? DataEHora { get; set; }

        //...
    }
}
