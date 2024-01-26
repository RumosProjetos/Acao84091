using DatabaseFirstDotnetCore.ConsoleApp.CamadaLogica;
using DatabaseFirstDotnetCore.ConsoleApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDotnetCore.ConsoleApp.CamadaAcessoDados
{
    internal class PessoaRepository : IRepository<Pessoa, int>
    {
        private readonly ConferenciaCientificaContext db;
        public PessoaRepository()
        {
            db = new ConferenciaCientificaContext(); 
        }

        public Pessoa? ObterPorId(int id)
        {
            //return db.Pessoas.Where(p => p.Id == id).FirstOrDefault();
            return db.Pessoas.FirstOrDefault(p => p.Id == id);
        }

        public List<Pessoa>? ObterTodos()
        {
            return db.Pessoas.ToList();
        }

        public List<Pessoa>? ObterTodosPorEspecialidade(string especialidade)
        {
            return db.Pessoas.Where(p => p.Especialidade == especialidade).ToList();
        }

        public List<Pessoa>? ObterTodosComEspecialidade()
        {
            return db.Pessoas.Where(p => p.Especialidade != null).ToList();
        }

        public void CriarNovo(Pessoa entidade)
        {
            //INSERT INTO PESSOAS (Nome, Especialidade, ...) values (@nome, @especialidade, ...)
            db.Pessoas.Add(entidade);
            db.SaveChanges();//Commit
        }

        public bool Atualizar(int id, Pessoa entidade)
        {
            Pessoa pessoa = db.Pessoas.FirstOrDefault(p => p.Id == id);
            if(pessoa != null)
            {
                pessoa.Nome = entidade.Nome;
                pessoa.Participacao = entidade.Participacao;
                pessoa.Especialidade = entidade.Especialidade;

                return db.SaveChanges() > 0;
            }

            return false;
        }

        public bool ApagarPorId(int id)
        {
            Pessoa pessoa = db.Pessoas.FirstOrDefault(p => p.Id == id);
            db.Pessoas.Remove(pessoa);

            return db.SaveChanges() > 0;
        }
    }
}
