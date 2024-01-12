namespace GestaoFrotas.ModeloDados.Entidades
{
    public class Automovel
    {
        public string? Matricula { get; set; } //Identificador
        public string? Modelo { get; set; }        
        public bool Ativo { get; set; }

        public Automovel(string matricula, string modelo)
        {
            Matricula = matricula;
            Modelo = modelo;
            Ativo = true;
        }
    }
}
