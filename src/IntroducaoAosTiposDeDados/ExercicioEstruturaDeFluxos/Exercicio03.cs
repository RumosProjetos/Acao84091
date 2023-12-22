namespace ExercicioEstruturaDeFluxos;

public class Exercicio03
{
    // Exercicio 3
    // Crie um programa que imprima a tabuada de um número escolhido pelo usuário.
    public static void Executar()
    {
        //TODO: Ler o valor escolhido pelo usuário
        int valorEscolhido = 5;

        for (int i = 1; i <= 10; i++)
        {
            int resultado = valorEscolhido * i;
            Console.WriteLine("Valor Escolhido: " + valorEscolhido + " x " + i + " = " + resultado);
        }
    }
}
