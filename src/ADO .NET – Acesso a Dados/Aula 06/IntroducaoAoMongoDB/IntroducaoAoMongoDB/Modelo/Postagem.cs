using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoAoMongoDB.Modelo
{
    public class Postagem
    {
        public Guid Id { get; set; }
        public string? Titulo { get; set; }
        public string? Conteudo { get; set; }
        public virtual List<Comentario>? Comentarios { get; set; }
        public List<byte[]>? Imagens { get; set; }
    }
}
