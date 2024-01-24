/*
SQLCOnnection - Efetiva a conexão com o database
SQLCommand - Executa um comando
*/

using System.Data.SqlClient;

string nomeServidor = "localhost\\SQLEXPRESS";//(localdb)\MSSQLLocalDB
string caminhoParaOBanco = $"Server={nomeServidor};Database=ConferenciaCientifica;Trusted_Connection=True;";


try
{
    SqlConnection minhaConexao = new SqlConnection(caminhoParaOBanco);
    minhaConexao.Open();

    string? NomeSelecionado = ExemploConsultaBaseadoNaParticipacaoComRiscoDeSQLInjection(minhaConexao, "Autor';SELECT @@ServerName;--");

    minhaConexao.Close();


    Console.WriteLine($"O nome selecionado foi: {NomeSelecionado}");
}
catch (SqlException ex)
{
    Console.WriteLine($"Erro na consulta: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Erro genérico: {ex.Message}");
}





static string? ExemploConsulta(SqlConnection minhaConexao)
{
    //Consulta....
    string comandoSQL = "SELECT TOP 1 Nome FROM Pessoas";

    //SqlCommand command = new SqlCommand(comandoSQL, minhaConexao); //Poderia utilizar dessa forma
    SqlCommand command = new SqlCommand();
    command.CommandText = comandoSQL;
    command.Connection = minhaConexao;

    var NomeSelecionado = command.ExecuteScalar().ToString();
    return NomeSelecionado;
}


static string? ExemploConsultaBaseadoNaParticipacaoComRiscoDeSQLInjection(SqlConnection minhaConexao, string participacao)
{
    //Consulta....
    string comandoSQL = "SELECT TOP 1 Nome FROM Pessoas WHERE Participacao = '"+participacao+"'";

    //SqlCommand command = new SqlCommand(comandoSQL, minhaConexao); //Poderia utilizar dessa forma
    SqlCommand command = new SqlCommand();
    command.CommandText = comandoSQL;
    command.Connection = minhaConexao;

    var NomeSelecionado = command.ExecuteScalar().ToString();
    return NomeSelecionado;
}


static string? ExemploConsultaBaseadoNaParticipacaoComParametros(SqlConnection minhaConexao, string participacao)
{
    //Consulta....
    string comandoSQL = "SELECT TOP 1 Nome FROM Pessoas WHERE Participacao = @part";

    //SqlCommand command = new SqlCommand(comandoSQL, minhaConexao); //Poderia utilizar dessa forma
    SqlCommand command = new SqlCommand();
    command.CommandText = comandoSQL;
    command.Connection = minhaConexao;
    command.Parameters.AddWithValue("part", participacao);

    var NomeSelecionado = command.ExecuteScalar().ToString();
    return NomeSelecionado;
}