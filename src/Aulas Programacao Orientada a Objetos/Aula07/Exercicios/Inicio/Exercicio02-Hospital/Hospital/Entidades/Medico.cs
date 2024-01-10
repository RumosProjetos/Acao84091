namespace Hospital.Entidades;

public class Medico : Pessoa
{
    public string Especialidade { get; set; }

    public Medico(string nome, int idade, string especialidade) : base(nome, idade)
    {
        Especialidade = especialidade;
    }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Especialidade: {Especialidade}");
    }

    public void PrescreverMedicacao(Paciente paciente)
    {
        Console.WriteLine($"O médico {Nome} prescreveu medicamentos para o paciente {paciente.Nome}.");
    }
}

