internal class Program
{
    /*
     * Implemente o algoritmo de ordenação Shell Sort para ordenar um array de números inteiros.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Algoritmo de Ordenação Shell Sort *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);

        Console.WriteLine("\n-------- Array original --------");
        ImprimirArray(array);

        ExecutarShellSort(array);

        Console.WriteLine("\n-------- Array ordenado --------");
        ImprimirArray(array);

        Console.ReadKey();
    }

    private static void LerArray(int[] array, int tamanhoDoArray) 
    {
        for (int i = 0; i < tamanhoDoArray; i++)
        {
            Console.Write($"Elemento [{i}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    private static void ExecutarShellSort(int[] array) 
    {
        int numero = array.Length;

        for (int intervalo = numero / 2; intervalo > 0; intervalo /= 2) 
        {
            for (int i = intervalo; i < numero; i += 1) 
            {
                int temp = array[i];

                int j;

                for (j = i; j >= intervalo && array[j - intervalo] > temp; j -= intervalo) 
                {
                    array[j] = array[j - intervalo];
                }

                array[j] = temp;
            }
        }
    }

    private static void ImprimirArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}