internal class Program
{
    /*
     * Faça um algoritmo que leia um array de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no array. 
     * Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no array!".
    */

    private static void Main(string[] args)
    {
        Console.WriteLine("***** Pesquisar Número no Array *****");

        int tamanhoDoVetor = 10;
        int[] array = new int[tamanhoDoVetor];

        for (int i = 0; i < tamanhoDoVetor; i++) 
        {
            Console.Write($"Digite o valor para a posição {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite um número para verificcar no array: ");
        int numeroN = int.Parse(Console.ReadLine());

        Console.WriteLine("\n---------- Resultado ----------");
        bool resultadoDaPesquisa = PesquisarNumeroNoArray(array, numeroN);

        if (resultadoDaPesquisa) 
        {
            Console.WriteLine($"O número {numeroN} foi encontrado no array!");
        }
        else 
        {
            Console.WriteLine($"O número {numeroN} não existe no array!");
        }

        Console.ReadKey();
    }

    private static bool PesquisarNumeroNoArray(int[] array, int numero) 
    {
        bool numeroEncontrado = false;

        for (int i = 0; i < array.Length; i++) 
        {
            if (array[i] == numero) 
            {
                return true;
            }
        }

        return false;
    }
}