namespace Banco.Entidades;

public class Cliente
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos.");
    }
}
