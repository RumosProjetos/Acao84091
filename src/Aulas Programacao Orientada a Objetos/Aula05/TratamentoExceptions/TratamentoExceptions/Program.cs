using TratamentoExceptions;

List<Funcionario> funcionariosDaEmpresa = new List<Funcionario>();

for (int i = 0; i < 1000; i++)
{
    Funcionario func = new Funcionario
    {
        Nome = "Funcionario" + i,
        Salario = i * 1000,
        TaxaDoSeguro = i
    };
    funcionariosDaEmpresa.Add(func);
}


foreach (var item in funcionariosDaEmpresa)
{
    //gerar pagamento
    item.SalarioLiquido();
    item.CalcularSeguroObrigatorio();
}


string condicao = "Verdadeiro";

if (condicao == "Verdadeiro")
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Funcionou");
        Console.WriteLine("Linha 02");
        Console.WriteLine("Linha 03");
    }
}

try
{
    string conteudo = File.ReadAllText(@"c:\temp\temp.txt");
}
catch (Exception)
{

}
