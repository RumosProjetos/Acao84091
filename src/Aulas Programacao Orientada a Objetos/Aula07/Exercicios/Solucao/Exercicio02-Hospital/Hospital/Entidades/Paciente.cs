namespace Hospital.Entidades;

public class Paciente : Pessoa
{
    public string HistoricoClinico { get; set; }
    public List<Medicamento> Medicamentos { get; set; }

    public Paciente(string nome, int idade, string historicoClinico) : base(nome, idade)
    {
        HistoricoClinico = historicoClinico;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Histórico Clínico: {HistoricoClinico}");
    }
}
