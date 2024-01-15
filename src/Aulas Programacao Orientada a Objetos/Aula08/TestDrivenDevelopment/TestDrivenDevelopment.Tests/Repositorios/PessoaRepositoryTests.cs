using TestDrivenDevelopment.DAL.Entidades;
using TestDrivenDevelopment.DAL.Repositorios;

namespace TestDrivenDevelopment.Tests.Repositorios
{
    [TestClass]
    public class PessoaRepositoryTests
    {
        const string path = @".\Database\Pessoa.json";

        [TestMethod]
        public void DeveVerificarSeODatabaseExisteAoInstanciarAClasse()
        {
            //Arrange - Prepare
            PessoaRepository pessoaRepository;

            //Act - faça algo
            pessoaRepository = new PessoaRepository();
            bool arquivoExiste = File.Exists(path);

            //Assert - verifique/teste
            Assert.IsTrue(arquivoExiste);
        }

        [TestMethod]
        public void DeveAdicionarUmaPessoaNoDatabase()
        {
            //Arrange - preparo
            PessoaRepository pessoaRepository = new PessoaRepository();

            //Act - ação
            Pessoa maria = new Pessoa();
            maria.Id = 1;
            maria.Ativo = true;
            maria.Sexo = "F";
            maria.Nome = "Maria João Calçada D'Avila \" #!$%&/\\\b\t\n ";

            pessoaRepository.Adicionar(maria);
            bool arquivoExiste = File.Exists(path);
            string conteudo = File.ReadAllText(path);
            bool arquivoContemDados = conteudo.Length > 0;

            //Assert - Verificacao
            Assert.IsNotNull(maria);
            Assert.IsTrue(arquivoExiste);
            Assert.IsTrue(arquivoContemDados);
        }

        [TestMethod]
        public void DeveCarregarTodasAsPessoasDeUmArquivoTexto()
        {
            //Arrange - preparo
            PessoaRepository pessoaRepository = new PessoaRepository();

            //Act - faça algo
            List<Pessoa> listaPessoas = pessoaRepository.BuscarTodos();
            
            //Assert - verificacao
            Assert.IsNotNull(listaPessoas);
        }

        [TestMethod]
        public void DeveLocalizarUmaPessoaAdicionadaNoDatabase()
        {
            //Arrange
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 1000;
            pessoa.Nome = "Pessoa Teste";
            pessoa.Ativo = true;
            pessoa.Sexo = "I";

            PessoaRepository pessoaRepository = new PessoaRepository();
            pessoaRepository.Adicionar(pessoa);

            //Act
            Pessoa pessoaAct = pessoaRepository.Buscar(1000);

            //Assert
            Assert.IsTrue(pessoaAct != null);
            Assert.AreEqual(pessoa.Nome, pessoaAct.Nome);
            Assert.AreEqual(pessoa.Ativo, pessoaAct.Ativo);
            Assert.AreEqual(pessoa.Sexo, pessoaAct.Sexo);
        }


        [TestMethod]
        public void NaoDeveLocalizarUmaPessoaNaoAdicionadaNoDatabase()
        {
            //Arrange
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 1000;
            pessoa.Nome = "Pessoa Teste";
            pessoa.Ativo = true;
            pessoa.Sexo = "I";

            PessoaRepository pessoaRepository = new PessoaRepository();
            pessoaRepository.Adicionar(pessoa);

            //Act
            Pessoa pessoaAct = pessoaRepository.Buscar(100000);

            //Assert
            Assert.IsNull(pessoaAct);
        }

        [TestMethod]
        public void DeveRemoverPessoaDaLista()
        {
            //Arrange
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 1000;
            pessoa.Nome = "Pessoa Teste";
            pessoa.Ativo = true;
            pessoa.Sexo = "I";

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Id = 2000;
            pessoa2.Nome = "Pessoa Teste";
            pessoa2.Ativo = true;
            pessoa2.Sexo = "F";

            Pessoa pessoa3 = new Pessoa();
            pessoa3.Id = 3000;
            pessoa3.Nome = "Pessoa Teste";
            pessoa3.Ativo = true;
            pessoa3.Sexo = "M";

            PessoaRepository pessoaRepository = new PessoaRepository();
            pessoaRepository.Adicionar(pessoa);
            pessoaRepository.Adicionar(pessoa2);
            pessoaRepository.Adicionar(pessoa3);
            int quantidadeInicial = pessoaRepository.BuscarTodos().Count();

            //Act
            pessoaRepository.Apagar(2000);
            int quantidadeRestanteBuscandoTodos = pessoaRepository.BuscarTodos().Count();
            int quantidadeRestanteComSubtracao = quantidadeInicial - 1;


            //Assert
            Assert.IsNotNull(pessoaRepository);
            Assert.AreEqual(3, quantidadeInicial);
            Assert.AreEqual(2, quantidadeRestanteBuscandoTodos);
            Assert.AreEqual(2, quantidadeRestanteComSubtracao);
        }

        [TestMethod]
        public void DeveAtualizarDadosDePessoaDaLista()
        {
            //Arrange
            Pessoa pessoa = new Pessoa();
            pessoa.Id = 1000;
            pessoa.Nome = "Pessoa Teste";
            pessoa.Ativo = true;
            pessoa.Sexo = "I";

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Id = 2000;
            pessoa2.Nome = "Pessoa Teste";
            pessoa2.Ativo = true;
            pessoa2.Sexo = "F";

            Pessoa pessoa3 = new Pessoa();
            pessoa3.Id = 3000;
            pessoa3.Nome = "Pessoa Teste";
            pessoa3.Ativo = true;
            pessoa3.Sexo = "M";

            PessoaRepository pessoaRepository = new PessoaRepository();
            pessoaRepository.Adicionar(pessoa);
            pessoaRepository.Adicionar(pessoa2);
            pessoaRepository.Adicionar(pessoa3);
            int quantidadeInicial = pessoaRepository.BuscarTodos().Count();

            //Act
            Pessoa pessoaNova = new Pessoa();
            pessoaNova.Id = 2000;
            pessoaNova.Nome = "Pessoa Diferente";
            pessoaNova.Sexo = "I";
            pessoaNova.Ativo = true;    

            pessoaRepository.Atualizar(2000, pessoaNova);
            int quantidadeRestanteBuscandoTodos = pessoaRepository.BuscarTodos().Count();

            Pessoa PessoaASerTestada = pessoaRepository.Buscar(2000);

            //Assert
            Assert.IsNotNull(pessoaRepository);
            Assert.AreEqual(3, quantidadeInicial);
            Assert.AreEqual(3, quantidadeRestanteBuscandoTodos);
            Assert.AreEqual("Pessoa Diferente", PessoaASerTestada.Nome);
            Assert.AreEqual("I", PessoaASerTestada.Sexo);
            Assert.AreEqual(true, PessoaASerTestada.Ativo);
        }
    }
}


//Try Catch
//independencia de testes