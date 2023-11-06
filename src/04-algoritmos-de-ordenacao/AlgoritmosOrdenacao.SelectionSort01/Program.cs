internal class Program
{
    /*
     * Implemente o algoritmo de ordenação Selection Sort para ordenar um array de números inteiros.
    */
    
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Algoritmo de Ordenação Selection Sort *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);

        ExecutarSelectionSort(array);

        Console.WriteLine("\n-------- Resultado --------");
        ImprimirArray(array);

        Console.ReadKey();
    }

    private static void LerArray (int[] array, int tamanhoDoArray) 
    {
        for (int i = 0; i < tamanhoDoArray; i++)
        {
            Console.Write($"Elemento [{i}] = ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    private static void ExecutarSelectionSort(int[] array) 
    {
        int numero = array.Length;

        for(int i = 0; i < numero - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numero; j++) 
            {
                if (array[j] < array[minIndex]) 
                {
                    minIndex = j;
                }
            }

            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
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