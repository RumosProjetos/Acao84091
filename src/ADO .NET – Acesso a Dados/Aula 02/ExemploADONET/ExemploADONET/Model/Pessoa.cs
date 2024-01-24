using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADONET.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Especialidade { get; set; }
        public string Filiacao { get; set; }
        public int NumeroInscricao { get; set; }
        public string Telefone { get; set; }
        public string Participacao { get; set; }
    }
}
