using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoAosTiposDeDados
{
    public class Pessoa
    {
        public string? Nome { get; set; }
    }

    public class Estudante : Pessoa
    {
        public string? Matricula { get; set; }
    }
}
