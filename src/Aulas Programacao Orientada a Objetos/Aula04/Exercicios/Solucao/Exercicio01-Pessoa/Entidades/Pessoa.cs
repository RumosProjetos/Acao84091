namespace Exercicio01_ClassePessoa.Entidades;

public class Pessoa
{
    // Atributos da classe
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Construtor da classe
    public Pessoa(string nome, int idade)
    {
        Nome = nome; 
        Idade = idade;
    }

    // Método para exibir informações sobre a pessoa
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos.");
    }

    //Método para calcular a idade em determinado ano
    public void CalcularIdade(int anoConsiderado)
    {
        var anoAtual = DateTime.Now.Year; //2024
        int idadeNoAnoInformado = Idade - (anoAtual - anoConsiderado) ;
        if(idadeNoAnoInformado < 0)
        {
            Console.WriteLine($"Em {anoConsiderado} {Nome} ainda não tinha nascido.");
            return;
        }

        if(idadeNoAnoInformado < Idade)
        {
            Console.WriteLine($"Em {anoConsiderado} {Nome} tinha {idadeNoAnoInformado} anos.");
        }
        else
        {
            Console.WriteLine($"Em {anoConsiderado} {Nome} terá {idadeNoAnoInformado} anos.");
        }
    }

    //M´todo para avaliar se é maior de idade
    public void InformarSeMaiorIdade()
    {
        if(Idade >= 18)
        {
            Console.WriteLine("É maior de idade");
        }
        else
        {
            Console.WriteLine("Não é maior de idade");
        }
    }
}
