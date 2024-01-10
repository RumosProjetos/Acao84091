using Hospital.Entidades;

Console.WriteLine("Hello, World!");

Paciente paciente = new Paciente("João", 30, "Hipertensão");
Medico medico = new Medico("Dr. Silva", 40, "Cardiologista");

Consulta consulta = new Consulta(medico, paciente, DateTime.Now);
consulta.RealizarConsulta();

Console.WriteLine("\nDetalhes do Paciente:");
paciente.ExibirInformacoes();

Console.WriteLine("\nDetalhes do Médico:");
medico.ExibirInformacoes();