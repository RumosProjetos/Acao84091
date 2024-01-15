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
    }
}


//Try Catch
//independencia de testes