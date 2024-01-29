using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PostagensBlog.Modelo
{
    public class Comentario
    {
        public int Id { get; set; }

        [Required]
        public string? Texto { get; set; }
        
        [Required]
        public DateTime DataEHora { get; set; }

        [Required]
        public Comentarista? Comentarista { get; set; }
    }
}
