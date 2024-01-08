using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace ConferenciaCientifica.Entidades
{
    internal class Autor : Participante
    {
        public void EscreverArtigo()
        {
            //Formata a data para string
            string dataAtual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); //20240108_205410

            //Monta o caminho se baseando na pasta local e depois junta com a dataAtual
            string caminho = @$".\meusArtigos\{dataAtual}.txt"; //20240108_205410.txt

            //Verifica se existe o caminho informado
            if (Directory.Exists(@$".\meusArtigos\") == false)
            {
                Directory.CreateDirectory(@$".\meusArtigos\");
            }

            //Loop para criar artigos com tamanhos diferentes
            int contador = new Random().Next(0, 1001);
            for (int i = 0; i < contador; i++)
            {
                //Adiciona um Guid no artigo criado
                File.AppendAllText(caminho, Guid.NewGuid().ToString());
            }   
        }
        public void EntregarArtigo()
        {
            //Formata a data para string
            string dataAtual = DateTime.Now.ToString("yyyyMMdd_HHmmss"); //20240108_205410

            //Verifica se existe o caminho informado
            if (Directory.Exists(@$".\meusArtigos\") == true)
            {
                //Verifica se existe o caminho informado
                if (Directory.Exists(@$".\meusZips\") == false)
                {
                    Directory.CreateDirectory(@$".\meusZips\");
                }

                ZipFile.CreateFromDirectory(@$".\meusArtigos\", @$".\meusZips\{dataAtual}.zip");
            }
        }
    }
}
