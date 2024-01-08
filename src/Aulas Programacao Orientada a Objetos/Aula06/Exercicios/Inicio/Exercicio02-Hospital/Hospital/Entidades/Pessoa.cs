namespace Hospital.Entidades;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos.");
    }
}
