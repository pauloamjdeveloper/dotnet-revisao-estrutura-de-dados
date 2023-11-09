internal class Program
{
    /*
     * Escreva um programa que encontre o maior elemento em um array usando busca linear 
    */
    
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Maior Elemento no Array *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);

        int maiorElementoArray = EncontrarMaiorElemento(array);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"O maior elemento do array é: {maiorElementoArray}");

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

    private static int EncontrarMaiorElemento(int[] array) 
    {
        int maiorElemento = array[0];

        for (int i = 1; i < array.Length; i++) 
        {
            if (array[i] > maiorElemento) 
            {
                maiorElemento = array[i];
            }
        }

        return maiorElemento;
    }
}