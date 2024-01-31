using IntroducaoAoLinq.ConsoleApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoAoLinq.ConsoleApp.Builder
{
    public class FotoBuilder
    {
        public readonly List<Foto> Fotos;

        public FotoBuilder()
        {
            Fotos = new List<Foto>();
            for (int i = 0; i < 9; i++)
            {
                Foto fotoAtual = new Foto
                {
                    Id = i,
                    Titulo = $"Cao-{i}",
                    DataCriacao = DateTime.Now,
                    Descricao = $"Foto Descricao-{i}-{Guid.NewGuid()}",
                    Fotografo = $"Fotografo-{(i % 2 == 0 ? "Joao" : "Maria")}",
                    ArquivoFoto = File.ReadAllBytes(@"Fotos\Cao" + i + ".jpg"),
                };

                fotoAtual.Comentarios = GerarComentarios(i, fotoAtual);
                Fotos.Add(fotoAtual);
            }
        }


        private List<Comentario> GerarComentarios(int quantidadeComentarios, Foto foto)
        {
            List<Comentario> resultado = new List<Comentario>();

            int comentarios = new Random().Next(0, 100);

            for (int i = 0; i < quantidadeComentarios * comentarios; i++)
            {
                Comentario comentarioNovo = new Comentario
                {
                    Assunto = foto.Titulo,
                    Texto = foto.Descricao + Guid.NewGuid().ToString(),
                    Foto = foto,
                    Usuario = $"Comentarista-{i}"
                };

                resultado.Add(comentarioNovo);
            }

            return resultado;
        }
    }
}
