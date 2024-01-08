using System.Text;
using TratamentoExceptions;

int valor1 = 10;
string meuLog = "c:\\temp\\log.txt";
// Big Farms Needs Red Tractors 
// B = backspace
// F = New Feed
// N = New Line (Volta pro começo)
// R = Retorno de Carro (volta pro começo da linha)
// T = Tab

//string meuLog = @"c:\temp\log.txt";

try
{
	int resultado = valor1 / 0;
}
catch(DivideByZeroException exemplo)
{
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine("Erro divisao Zero:");
    stringBuilder.AppendLine("======================");
    stringBuilder.AppendLine("Data e hora: " + DateTime.Now);
    stringBuilder.AppendLine("Exceção: " + exemplo.Message);
    stringBuilder.AppendLine("Detalhe: " + exemplo.StackTrace);
    stringBuilder.AppendLine("Detalhe mais preciso: " + exemplo.InnerException);

    File.AppendAllText(meuLog, stringBuilder.ToString());
}
catch (Exception qualquercoisa)
{
	StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine("Erro:");
    stringBuilder.AppendLine("======================");
    stringBuilder.AppendLine("Data e hora: " + DateTime.Now);
    stringBuilder.AppendLine("Exceção: " + qualquercoisa.Message);
    stringBuilder.AppendLine("Detalhe: " + qualquercoisa.StackTrace);

    File.AppendAllText(meuLog, stringBuilder.ToString());
}
finally
{

}



try
{
    ClasseEstatica.Exemplo();
}
catch (Exception)
{
}
