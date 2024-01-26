using System;
using System.Collections.Generic;

namespace DatabaseFirstDotnetCore.ConsoleApp.Modelo;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Especialidade { get; set; }

    public string? Filiacao { get; set; }

    public int? NumeroInscricao { get; set; }

    public string? Telefone { get; set; }

    public string Participacao { get; set; } = null!;

    public virtual ICollection<Artigo> ArtigoAutors { get; set; } = new List<Artigo>();

    public virtual ICollection<Artigo> ArtigoPalestrantes { get; set; } = new List<Artigo>();

    public virtual ICollection<Palestra> Palestras { get; set; } = new List<Palestra>();
}
