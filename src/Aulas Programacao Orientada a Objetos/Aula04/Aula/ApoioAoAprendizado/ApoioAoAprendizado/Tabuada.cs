using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoioAoAprendizado
{
    internal class Tabuada
    {
        public Tabuada(int valorBase)
        {
            ValorBase = valorBase;
            ValoresCalculados = new int[10];
        }

        public int ValorBase { get; set; }
        public int[] ValoresCalculados { get; set; }

        public void Calcular()
        {
            for (int i = 0; i < 10; i++)
            {
                ValoresCalculados[i] = ValorBase * (i + 1);
            }
        }
    }
}
