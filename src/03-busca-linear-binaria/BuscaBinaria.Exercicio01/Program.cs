internal class Program
{
    /*
     * Crie um programa que verifique se um array de inteiros está ordenado de forma crescente. 
     * Use a busca binária para essa tarefa. Se a lista estiver desordenada, indique que ela não está ordenada.
    */
    
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Verificar Ordenação de Array *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);

        bool ordenacaoDeArray = VerificarOrdenacaoDeArray(array);

        Console.WriteLine("\n-------- Resultado --------");

        if (ordenacaoDeArray)
        {
            Console.WriteLine("O array está ordenado de forma crescente.");
        }
        else
        {
            Console.WriteLine("O array NÃO está ordenado de forma crescente.");
        }

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

    private static bool VerificarOrdenacaoDeArray(int[] array) 
    {
        for(int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1]) 
            {
                return false;
            }
        }

        return true;
    }
}