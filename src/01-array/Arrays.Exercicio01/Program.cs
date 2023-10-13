internal class Program
{
    /*
     * Escreva um algoritmo que leia os valores para um array de 10 elementos e então mostre 
     * na tela a quantidade de números pares e ímpares.
    */

    private static void Main(string[] args)
    {
        int tamanhoDoArray = 10;
        int[] array = new int[tamanhoDoArray];
        int numerosPares = 0;
        int numerosImpares = 0;

        LerArray(array, tamanhoDoArray);
        ContarParesEImpares(array, ref numerosPares, ref numerosImpares);

        Console.WriteLine("\n-------- Resultado --------");
        Console.WriteLine($"Quantidade de núemros pares: {numerosPares}");
        Console.WriteLine($"Quantidade de núemros pares: {numerosImpares}");

        Console.ReadKey();
    }

    private static void LerArray(int[] array, int tamanhoDoVetor) 
    {
        for(int i = 0; i < tamanhoDoVetor; i++) 
        {
            Console.Write($"Digite o valor para o elemento {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    private static void ContarParesEImpares(int[] array, ref int pares, ref int impares) 
    {
        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] % 2 == 0) 
            {
                pares++;
            }
            else 
            {
                impares++;
            } 
        }
    }
}