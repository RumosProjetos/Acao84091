using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.PostagensBlog.Modelo
{
    public class Postagem
    {
        [Key] //Primary Key - Chave Primária
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Conteudo { get; set; }
    }
}
