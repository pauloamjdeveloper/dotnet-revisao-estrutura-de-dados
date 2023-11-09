internal class Program
{
    /*
     * Crie um programa que conte o número de ocorrências de um elemento específico em um array usando busca linear. 
     * Peça ao usuário para inserir um elemento e, em seguida, conte quantas vezes ele aparece na lista.
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Contador de Ocorrências *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);

        Console.Write("Informe o elemento que deseja contar: ");
        int elemento = int.Parse(Console.ReadLine());

        int ocorrencias = ContadorDeOcorrencias(array, elemento);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"O elemento {elemento} aparece {ocorrencias} vezes no array.");

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

    private static int ContadorDeOcorrencias(int[] array, int elemento) 
    {
        int contador = 0;

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] == elemento) 
            {
                contador++;
            }
        }

        return contador;
    }
}