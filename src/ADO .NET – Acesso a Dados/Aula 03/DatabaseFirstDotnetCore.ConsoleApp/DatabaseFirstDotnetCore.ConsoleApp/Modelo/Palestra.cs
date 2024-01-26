using System;
using System.Collections.Generic;

namespace DatabaseFirstDotnetCore.ConsoleApp.Modelo;

public partial class Palestra
{
    public int Id { get; set; }

    public int AutorId { get; set; }

    public int ArtigoId { get; set; }

    public DateTime DataEhora { get; set; }

    public virtual Artigo Artigo { get; set; } = null!;

    public virtual Pessoa Autor { get; set; } = null!;
}
