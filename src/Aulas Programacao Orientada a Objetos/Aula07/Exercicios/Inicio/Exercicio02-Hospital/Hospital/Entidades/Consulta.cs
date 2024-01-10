namespace Hospital.Entidades;

public class Consulta
{
    public Medico Medico { get; set; }
    public Paciente Paciente { get; set; }
    public DateTime DataConsulta { get; set; }

    public Consulta(Medico medico, Paciente paciente, DateTime dataConsulta)
    {
        Medico = medico;
        Paciente = paciente;
        DataConsulta = dataConsulta;
    }

    public void RealizarConsulta()
    {
        Console.WriteLine($"Consulta realizada em {DataConsulta} pelo médico {Medico.Nome} para o paciente {Paciente.Nome}.");
        Medico.PrescreverMedicacao(Paciente);
    }
}

