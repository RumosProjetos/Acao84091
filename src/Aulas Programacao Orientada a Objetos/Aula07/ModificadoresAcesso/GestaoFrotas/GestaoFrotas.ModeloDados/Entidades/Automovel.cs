namespace GestaoFrotas.ModeloDados.Entidades
{
    public class Automovel
    {
        public string? Modelo { get; set; }
        public string? Matricula { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
