internal class Program
{
    /*
     * Escreva um algoritmo que leia 2 arrays X[10] e Y[10] e os escreva. Crie, a seguir, um array para cada uma das operações:
	 * A união de X com Y
	 * A diferença entre X e Y
	 * A interseção entre X e Y
     * Escreva o vetor resultado de cada uma das operações.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Exibir Operações em Arrays *****");

        int[] X = new int[10];
        int[] Y = new int[10];

        Console.WriteLine("Digite 10 valores para o array X:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"X[{i}] = ");
            X[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite 10 valores para o array Y:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Y[{i}] = ");
            Y[i] = int.Parse(Console.ReadLine());
        }

        int[] uniao = VerificarUniao(X, Y);
        int[] diferenca = VerificarDiferenca(X, Y);
        int[] intersecao = VerificarIntersecao(X, Y);

        Console.WriteLine("\n---------- Resultado ----------");

        Console.WriteLine("\nUnião de X e Y:");
        ExibirArray(uniao);

        Console.WriteLine("\nDiferença entre X e Y:");
        ExibirArray(diferenca);

        Console.WriteLine("\nInterseção entre X e Y:");
        ExibirArray(intersecao);

        Console.ReadKey();
    }

    private static int[] VerificarUniao(int[] array1, int[] array2)
    {
        int[] resultado = new int[20];

        for (int i = 0; i < 10; i++)
        {
            resultado[i] = array1[i];
        }

        for (int i = 0; i < 10; i++)
        {
            bool valorEncontrado = false;

            for (int j = 0; j < 10; j++)
            {
                if (array2[i] == resultado[j])
                {
                    valorEncontrado = true;
                    break;
                }
            }

            if (!valorEncontrado)
            {
                resultado[10 + i] = array2[i];
            }
        }

        return resultado;
    }

    private static int[] VerificarDiferenca(int[] array1, int[] array2)
    {
        int[] resultado = new int[10];

        for (int i = 0; i < 10; i++)
        {
            bool valorEncontrado = false;

            for (int j = 0; j < 10; j++)
            {
                if (array1[i] == array2[j])
                {
                    valorEncontrado = true;
                    break;
                }
            }

            if (!valorEncontrado)
            {
                resultado[i] = array1[i];
            }
        }

        return resultado;
    }

    private static int[] VerificarIntersecao(int[] array1, int[] array2)
    {
        int[] resultado = new int[10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (array1[i] == array2[j])
                {
                    resultado[i] = array1[i];
                    break;
                }
            }
        }

        return resultado;
    }

    private static void ExibirArray(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] != 0)
            {
                Console.Write($"{vetor[i]} ");
            }
        }
        Console.WriteLine();
    }
}