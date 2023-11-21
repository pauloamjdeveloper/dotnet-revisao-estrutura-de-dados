internal class Program
{
    /*
     * Implemente o algoritmo de ordenação Quick Sort para ordenar o resultado de uma array.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Algoritmo de Ordenação Quick Sort *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());
        
        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);

        Console.WriteLine("\n-------- Array original --------");
        ImprimirArray(array);

        OrdenarArray(array, 0, tamanhoDoArray - 1);

        Console.WriteLine("\n-------- Array ordenado --------");
        ImprimirArray(array);
        
        Console.ReadKey();
    }

    private static void OrdenarArray(int[] array, int baixo, int alto) 
    {
        if (baixo < alto) 
        {
            int indice = ParticionarUltimoElemento(array, baixo, alto);
            OrdenarArray(array, baixo, indice - 1);
            OrdenarArray(array, indice + 1, alto);
        }
    }

    private static int ParticionarUltimoElemento(int[] array, int baixo, int alto) 
    {
        int pivo = array[alto];
        int i = baixo - 1;

        for(int j = baixo; j < alto; j++ )
        {
            if (array[j] <= pivo) 
            {
                i++;
                SubstituirElemento(array, i, j);
            }
        }

        SubstituirElemento(array, i + 1, alto);

        return i + 1;
    }

    private static void SubstituirElemento(int[] array, int i, int j) 
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    private static void LerArray(int[] array, int tamanhoDoArray) 
    {
        for (int i = 0; i < tamanhoDoArray; i++)
        {
            Console.Write($"Elemento [{i}] = ");
            array[i] = int.Parse(Console.ReadLine());
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