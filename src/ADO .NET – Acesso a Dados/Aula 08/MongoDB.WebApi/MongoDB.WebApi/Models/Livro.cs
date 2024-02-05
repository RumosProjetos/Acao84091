using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MongoDB.WebApi.Models
{
    public class Livro
    {
        //Seria no caso do SQLServer
        //[DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(3)]
        public string? Nome { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Autor { get; set; }
        
        [MaxLength(150)]
        public string? Categoria { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public decimal Preco { get; set; }
    }
}
