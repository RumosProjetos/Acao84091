using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDatabaseFirst.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConferenciaCientificaEntities db = new ConferenciaCientificaEntities();
            Pessoas pessoa = db.Pessoas.First();

            //LINQ
            //Trazer todos os objetos
            Pessoas pessoa2 = (from p in db.Pessoas 
                               select p)
                              .FirstOrDefault();

            //Trazer apenas a pessoa com ID = 1
            Pessoas pessoaId1 = (from p in db.Pessoas
                                 where p.Id == 1
                                 select p)
                           .FirstOrDefault();

            //Trazer pessoa usando duas regras
            Pessoas pessoaId1NomeMaria = (from p in db.Pessoas
                                          where p.Id == 1
                                             && p.Nome == "Maria"
                                          select p)
                           .FirstOrDefault();

            //Trazer pessoas usando duas regras, ordenando por campo
            Pessoas pessoaId2NomeMaria = (from p in db.Pessoas
                                          where p.Id == 2
                                             && p.Nome == "Maria"
                                          orderby p.Participacao descending 
                                          select p
                                         )

                           .FirstOrDefault();


            //LINQ FluentAPI
            //Select * from pessoas
            List<Pessoas> buscarTodos = db.Pessoas.ToList();

            //Select top 1 * from pessoas p where p.Id = 1
            Pessoas pessoaId1Linq = db.Pessoas.Where(p => p.Id == 1).FirstOrDefault();

            //Select top 1 * from pessoas p where p.Id = 1 and p.nome = 'Maria'
            Pessoas pessoaId1NomeMariaFluenteApi = db.Pessoas.Where(p => p.Id == 1 && p.Nome == "Maria").FirstOrDefault();

            //Select top 1 * from pessoas p where p.Id = 1 and p.nome like 'Maria%'
            Pessoas p2 = db.Pessoas.Where(p => p.Id == 1 && p.Nome.StartsWith("Maria")).FirstOrDefault();

            //Select top 1 nome, especialidade from pessoas p where p.Id = 1
            var p3 = db.Pessoas.Where(p => p.Id == 1).Select(p => new { p.Nome, p.Especialidade }).FirstOrDefault();


            //Select top 1 nome from pessoas p where p.Id = 1
            String nomeEscolhido = db.Pessoas.Where(p => p.Id == 1).FirstOrDefault().Nome;



            Console.WriteLine(pessoa.Nome);
        }
    }
}
