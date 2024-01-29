namespace DatabaseFirstDotnetCore.ConsoleApp.Modelo;

public partial class Artigo
{
    public int Id { get; set; }

    public string Titulo { get; set; } = null!;

    public string? Abstract { get; set; }

    public int AutorId { get; set; }

    public int PalestranteId { get; set; }

    public virtual Pessoa Autor { get; set; } = null!;

    public virtual Pessoa Palestrante { get; set; } = null!;

    public virtual ICollection<Palestra> Palestras { get; set; } = new List<Palestra>();
}
