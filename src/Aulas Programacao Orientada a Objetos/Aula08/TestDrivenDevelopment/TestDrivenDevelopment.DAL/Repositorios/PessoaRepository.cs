using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrivenDevelopment.DAL.Entidades;
using System.Text.Json;

namespace TestDrivenDevelopment.DAL.Repositorios
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        private List<Pessoa> pessoaList;
        const string path = @".\Database\Pessoa.json";
        const string diretorio = @".\Database\";

        public PessoaRepository()
        {
            pessoaList = new List<Pessoa>();
            GerarDatabase();
            //Falta tentarmos ler o conteúdo
        }

 

        public void Adicionar(Pessoa entidade)
        {
            pessoaList.Add(entidade);
            Gravar();
        }

        public void Apagar(int id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(int id, Pessoa entidade)
        {
            throw new NotImplementedException();
        }

        public Pessoa Buscar(int id)
        {
            List<Pessoa> listaLocal = BuscarTodos();

            foreach (Pessoa p in listaLocal)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }

            return null;
        }

        public List<Pessoa> BuscarTodos()
        {
            //Primeiro carregar o arquivo texto para uma String
            string conteudo = File.ReadAllText(path);

            //Desserializar o arquivo texto em um (lista de) objetos
            pessoaList = JsonSerializer.Deserialize<List<Pessoa>>(conteudo);

            return pessoaList;
        }

        public void Gravar()
        {
            string conteudo = JsonSerializer.Serialize(pessoaList);
            File.WriteAllText(path, conteudo);
        }


        private static void GerarDatabase()
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
