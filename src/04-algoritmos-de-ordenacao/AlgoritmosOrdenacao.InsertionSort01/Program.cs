internal class Program
{
    /*
     * Implemente o algoritmo de ordenação Insertion Sort para ordenar um array de números inteiros.
    */
    
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Algoritmo de Ordenação Insertion Sort *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);
        
        Console.WriteLine("\n-------- Array original --------");
        ImprimirArray(array);

        ExecutarInsertionSort(array);

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

    private static void ExecutarInsertionSort(int[] array) 
    {
        int numero = array.Length;

        for(int i = 1; i < numero; i++) 
        {
            int key = array[i];
            int j = i - 1;

            for (j = i - 1; j >= 0 && array[j] > key; j--) 
            {
                array[j + 1] = array[j];
            }

            array[j + 1] = key;
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