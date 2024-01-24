using ExemploADONET.BusinessLogicLayer;
using ExemploADONET.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploADONET.DataAccessLayer
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        SqlConnection _connection;
        public PessoaRepository(SqlConnection connection)
        {
            _connection = connection;
        }

        public int Apagar(int id)
        {
            string comandoSQL = "DELETE FROM Pessoas WHERE Id = @pId";
            SqlCommand cmd = new SqlCommand(comandoSQL, _connection);
            cmd.Parameters.AddWithValue("pId", id);

            return cmd.ExecuteNonQuery();
        }

        public int Atualizar(int id, Pessoa entidade)
        {
            string comandoSQL = "UPDATE Pessoas SET  " +
                "Nome = @pNome, " +
                "Especialidade = @pEspecialidade, " +
                "Filiacao = @pFiliacao, " +
                "NumeroInscricao = @pNumeroInscricao, " +
                "Telefone = @pTelefone, " +
                "Participacao = @pParticipacao " +
                "WHERE Id = @pId";
            SqlCommand cmd = new SqlCommand(comandoSQL, _connection);
            cmd.Parameters.AddWithValue("pId", id);
            cmd.Parameters.AddWithValue("pNome", entidade.Nome);
            cmd.Parameters.AddWithValue("pEspecialidade", entidade.Especialidade);
            cmd.Parameters.AddWithValue("pFiliacao", entidade.Filiacao);
            cmd.Parameters.AddWithValue("pNumeroInscricao", entidade.NumeroInscricao);
            cmd.Parameters.AddWithValue("pTelefone", entidade.Telefone);
            cmd.Parameters.AddWithValue("pParticipacao", entidade.Participacao);

            return cmd.ExecuteNonQuery();
        }

        public List<Pessoa> BuscarTodos()
        {
            List<Pessoa> pessoasEncontradas = new List<Pessoa>();

            string comandoSQL = "SELECT Id, Nome, Participacao " +
                                "FROM Pessoas ";
            SqlCommand cmd = new SqlCommand(comandoSQL, _connection);
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Id = reader.GetInt32(0);
                pessoa.Nome = reader.GetString(1);
                pessoa.Participacao = reader.GetString(2);

                //pessoa.Especialidade = reader.GetString(2);
                //pessoa.Filiacao = reader.GetString(3);
                //pessoa.NumeroInscricao = reader.GetInt32(4);
                //pessoa.Telefone = reader.GetString(5);


                pessoasEncontradas.Add(pessoa);
            }

            return pessoasEncontradas;
        }

        public void CriarNovo(Pessoa entidade)
        {
            string comandoSQL = "INSERT INTO Pessoas (Nome, Especialidade, Filiacao, NumeroInscricao, Telefone, Participacao) " +
                                "VALUES (@pNome, @pEspecialidade, @pFiliacao, @pNumeroInscricao, @pTelefone, @pParticipacao)  ";
            SqlCommand cmd = new SqlCommand(comandoSQL, _connection);
            cmd.Parameters.AddWithValue("pNome", entidade.Nome);
            cmd.Parameters.AddWithValue("pEspecialidade", entidade.Especialidade);
            cmd.Parameters.AddWithValue("pFiliacao", entidade.Filiacao);
            cmd.Parameters.AddWithValue("pNumeroInscricao", entidade.NumeroInscricao);
            cmd.Parameters.AddWithValue("pTelefone", entidade.Telefone);
            cmd.Parameters.AddWithValue("pParticipacao", entidade.Participacao);

            cmd.ExecuteNonQuery();
        }

        public Pessoa ObterPorId(int id)
        {
            Pessoa pessoaEncontrada = new Pessoa();

            string comandoSQL = "SELECT Id, Nome, Especialidade, Filiacao, NumeroInscricao, Telefone, Participacao " +
                                "FROM Pessoas " +
                                "WHERE Id = @pId";
            SqlCommand cmd = new SqlCommand(comandoSQL, _connection);
            cmd.Parameters.AddWithValue("pId", id);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                pessoaEncontrada.Id = reader.GetInt32(0);
                pessoaEncontrada.Nome = reader.GetString(1);
                pessoaEncontrada.Especialidade = reader.GetString(2);
                pessoaEncontrada.Filiacao = reader.GetString(3);
                pessoaEncontrada.NumeroInscricao = reader.GetInt32(4);
                pessoaEncontrada.Telefone = reader.GetString(5);
                pessoaEncontrada.Participacao = reader.GetString(6);
            }

            return pessoaEncontrada;
        }
    }
}
