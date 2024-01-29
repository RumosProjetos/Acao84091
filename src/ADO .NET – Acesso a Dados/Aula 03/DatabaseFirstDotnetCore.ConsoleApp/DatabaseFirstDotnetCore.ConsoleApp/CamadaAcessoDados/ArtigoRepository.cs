using DatabaseFirstDotnetCore.ConsoleApp.CamadaLogica;
using DatabaseFirstDotnetCore.ConsoleApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstDotnetCore.ConsoleApp.CamadaAcessoDados
{
    public class ArtigoRepository : IRepository<Artigo, int>
    {
        private readonly ConferenciaCientificaContext db;
        public ArtigoRepository()
        {
            db = new ConferenciaCientificaContext();
        }

        public bool ApagarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Atualizar(int id, Artigo entidade)
        {
            throw new NotImplementedException();
        }

        public void CriarNovo(Artigo entidade)
        {
            db.Artigos.Add(entidade);
            db.SaveChanges();
        }

        public Artigo? ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Artigo>? ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
