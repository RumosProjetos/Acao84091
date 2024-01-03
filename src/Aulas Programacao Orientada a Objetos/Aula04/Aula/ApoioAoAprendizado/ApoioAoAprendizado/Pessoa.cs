using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApoioAoAprendizado
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public int[] Notas { get; set; }

        public int[,] NotasPorDisciplina { get; set; }

        public List<string> MusicasFavoritas { get; set; }

        public override string ToString()
        {
            string resultado = Apoio.LabelNome + Nome;
            return resultado;
        }
    }

    public class PessoaEspecial : Pessoa
    {
        public string Nif { get; set; }
    }

   
}
