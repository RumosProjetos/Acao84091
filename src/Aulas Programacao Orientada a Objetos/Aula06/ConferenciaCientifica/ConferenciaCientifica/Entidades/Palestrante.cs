using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Palestrante : Autor
    {
        public List<Palestra> Palestra { get; set; }

        public void Palestrar() { }
        public void ResponderPerguntas(string pergunta) { }
    }
}
