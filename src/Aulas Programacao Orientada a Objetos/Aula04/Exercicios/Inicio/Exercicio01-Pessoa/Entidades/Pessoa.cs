namespace Exercicio01_ClassePessoa.Entidades;

internal class Pessoa
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
}
