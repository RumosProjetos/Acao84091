namespace IntroducaoAoMongoDB.Modelo
{
    public class Comentario
    {
        public Guid Id { get; set; }
        public string? Texto { get; set; }
        public DateTime? DataEHora { get; set; }
        public string? EmailComentarista { get; set; }
    }
}
