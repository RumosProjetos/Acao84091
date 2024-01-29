using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PostagensBlog.Modelo
{
    public class Comentarista
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [MinLength(3)]
        [MaxLength(300)]
        public string? Nome { get; set; }

        [Required]
        [MaxLength(300)]
        public string? EmailComentarista { get; set; }

        public bool Ativo { get; set; }
    }
}
