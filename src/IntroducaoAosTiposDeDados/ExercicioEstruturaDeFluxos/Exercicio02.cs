namespace ExercicioEstruturaDeFluxos;

public class Exercicio02
{
    // Exercicio 2
    // Modifique o exercício anterior para apresentar os múltiplos de 3.
    // [Resto da divisão por 3 é igual a 0]
    // Para os múltiplos de 3, imprima "Múltiplo de 3".
    // Se o número for múltiplo de 6, imprima "Múltiplo de 6" ao invés de "Múltiplo de 3".
    public static void Resultado()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                if (i % 2 == 0) //(i % 6 == 0)
                {
                    Console.WriteLine(i + " Múltiplo de 6");
                }
                else
                {
                    Console.WriteLine(i + " Múltiplo de 3");
                }
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    /// <summary>
    /// Ambos podem ser utilizados, mas o primeiro é mais performático. 
    /// Já que o segundo faz duas operações de resto de divisão.
    /// </summary>
    public static void ResultadoSegundaForma()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 2 == 0)
            {
                Console.WriteLine(i + " Múltiplo de 6");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(i + " Múltiplo de 3");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
