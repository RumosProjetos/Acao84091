using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoAoLinq.ConsoleApp.Modelo
{
    public class Foto
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public byte[]? ArquivoFoto { get; set;}
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string? Fotografo { get; set; }
        public virtual List<Comentario>? Comentarios { get; set; }
    }
}
