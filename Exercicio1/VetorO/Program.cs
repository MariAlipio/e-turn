using System;

namespace VetorO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implemente uma função que retorne um array de inteiros ordenado em ordem crescente, esta função recebe arrays de inteiro ordenados. 
            int[] V1 = new int[] { 1, 2, 3, 5, 6 };
            int[] V2 = new int[] { 2, 3, 4, 7, 8, 9 };

            var Resultado = new RetornaVetor();

            int[] Vetor = Resultado.Retorna(V1, V2);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Função que retorne um array de inteiros ordenado em ordem crescente! ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("O resultado é: {");
            for (int x = 0; x < Vetor.Length; x++)
            {
                Console.Write(" " + Vetor[x]);
            }
            Console.WriteLine(" }");
            Console.ReadKey();
        }
    }
}
