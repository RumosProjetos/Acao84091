using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Expectador : Pessoa
    {
        public int NumeroInscricao { get; set; }
        public string Telefone { get; set; }

        public void TomarNotas() { }
        public string FazerPerguntas()
        {
            throw new NotImplementedException();
        }
    }
}
