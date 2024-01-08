using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Avaliador : Participante
    {
        public List<Palestra> Palestras { get; set; }
    }
}
