using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConferenciaCientifica.Entidades
{
    internal class Expectador : Pessoa
    {
        public int NumeroInscricao { get; set; }
        public string Telefone { get; set; }

        /// <summary>
        /// Guarda em formato texto as notas da palestra
        /// </summary>
        /// <param name="notas"></param>
        public void TomarNotas(string notas) {
            //Formata a data para string
            string dataAtual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); //20240108_205410

            //Monta o caminho se baseando na pasta local e depois junta com a dataAtual
            string caminho = @$".\minhasNotas\{dataAtual}.txt"; //20240108_205410.txt

            //Verifica se existe o caminho informado
            if (Directory.Exists(@$".\minhasNotas\") == false)
            {
                Directory.CreateDirectory(@$".\minhasNotas\");
            }

            File.AppendAllText(caminho, notas);
        }

        /// <summary>
        /// Formata a pergunta e prepara para o palestrante
        /// </summary>
        /// <param name="pergunta"></param>
        /// <returns></returns>
        public string FazerPerguntas(string pergunta)
        {
            return $"A Pergunta foi: '{pergunta}'";
        }
    }
}
