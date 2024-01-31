namespace IntroducaoAoLinq.ConsoleApp.Modelo
{
    public class Comentario {
        public int Id { get; set; }        
        public int FotoId { get; set; }
        public string? Usuario { get; set; }
        public string? Assunto { get; set; }
        public string? Texto { get; set; }
        public virtual Foto? Foto { get; set; } 

    }
}
