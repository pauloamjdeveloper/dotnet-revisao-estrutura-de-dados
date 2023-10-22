internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***** Pesquisar Elemento com Busca Binária  *****");

        Console.Write("Informe o tamanho do array: ");
        int tamanhoDoArray = int.Parse(Console.ReadLine());

        int[] array = new int[tamanhoDoArray];
        LerArray(array, tamanhoDoArray);

        Console.Write("\nInforme o valor a ser procurado: ");
        int valor = int.Parse(Console.ReadLine());

        int resultadoDaPesquisa = BuscaBinaria(array, valor);

        Console.WriteLine("\n-------- Resultado --------");

        if (resultadoDaPesquisa != -1) 
        {
            Console.WriteLine($"O valor {valor} foi encontrado no índice {resultadoDaPesquisa}.");
        }
        else 
        {
            Console.WriteLine($"O valor {valor} não foi encontrado no array.");
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

    private static int BuscaBinaria(int[] array, int valor)
    {
        int anterior = 0;
        int posterior = array.Length - 1;

        while (anterior <= posterior)
        {
            int elemento = anterior + (posterior - anterior) / 2;

            if (array[elemento] == valor)
            {
                return elemento; 
            }
            else if (array[elemento] < valor)
            {
                anterior = elemento + 1; 
            }
            else
            {
                posterior = elemento - 1; 
            }
        }

        return -1;
    }
}