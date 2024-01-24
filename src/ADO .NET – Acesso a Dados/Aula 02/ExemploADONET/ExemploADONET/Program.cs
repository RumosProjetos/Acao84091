using ExemploADONET.DataAccessLayer;
using ExemploADONET.Model;
using System.Data.SqlClient;

string nomeServidor = "localhost\\SQLEXPRESS";//(localdb)\MSSQLLocalDB
string caminhoParaOBanco = $"Server={nomeServidor};Database=ConferenciaCientifica;Trusted_Connection=True;";


SqlConnection minhaConexao = new SqlConnection(caminhoParaOBanco);
minhaConexao.Open();

PessoaRepository pessoaRepository = new PessoaRepository(minhaConexao);

Pessoa Carlos = new Pessoa
{
    Nome = "Carlos da Silva",
    Participacao = "Participante",
    Especialidade = "Engenheiro",
    Filiacao = "USP",
    NumeroInscricao = 122233,
    Telefone = "987654321"
};

//pessoaRepository.CriarNovo(Carlos);

//pessoaRepository.Apagar(5);

Pessoa MariaDadosNovos = new Pessoa
{
    Nome = "Maria Casada",
    Participacao = "Autor",
    Especialidade = "Medicina",
    Filiacao = "ULISBOA",
    NumeroInscricao = 122233,
    Telefone = "123456789"
};
//pessoaRepository.Atualizar(1, MariaDadosNovos);

//Pessoa pessoa = pessoaRepository.ObterPorId(2);

List<Pessoa> pessoas = pessoaRepository.BuscarTodos();

minhaConexao.Close();