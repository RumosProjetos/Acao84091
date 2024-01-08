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

        public void GerarRelatorio(string anotacoes) {
            //Formata a data para string
            string dataAtual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); //20240108_205410

            //Monta o caminho se baseando na pasta local e depois junta com a dataAtual
            string caminho = @$".\meusRelatorios\{dataAtual}.txt"; //20240108_205410.txt

            //Verifica se existe o caminho informado
            if (Directory.Exists(@$".\meusRelatorios\") == false)
            {
                Directory.CreateDirectory(@$".\meusRelatorios\");
            }

            File.AppendAllText(caminho, anotacoes);
        }
        public int Avaliar()
        {
            return new Random().Next(0,21);
        }
    }
}
