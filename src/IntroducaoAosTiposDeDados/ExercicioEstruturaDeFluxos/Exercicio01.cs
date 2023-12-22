namespace ExercicioEstruturaDeFluxos;

public class Exercicio01
{
    // Exercicio 1
    // Escreva um programa que imprima todos os números inteiros de 1 a 100.
    // Se o número for par, imprima "PAR" ao lado do número.
    // [Resto da divisão por 2 é igual a 0]
    public static void Resultado()
    {
        for (int i = 1; i <= 100; i++) 
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " - PAR ");
            }else
            {
                Console.WriteLine(i);
            }
        }
    }
}
