using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 2 - Implemente uma função que receba um array de inteiros e retorne o segundo maior valor contido neste parâmetro de entrada
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Função que retorne o segundo maior do vetor");
            Compara Vetor = new Compara();
            int[] meuvet = new int[] { 5, 8, 7, 11, 25, 23, 20, 18, 100 };

            int[] ordenado = Vetor.RetornaSegundoMaior(meuvet);

            Console.ForegroundColor = ConsoleColor.White;
            //Escreve o vetor ordenado
            Console.Write("Seu vetor ordenado é:{");
            for (int x = 0; x < ordenado.Length; x++)
            {
                Console.Write(" " + ordenado[x]);
            }
            Console.WriteLine(" }");

            //Retorna o segundo maior valor
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("O segundo maior valor é: " + ordenado[ordenado.Length - 2]);
            Console.ReadKey();

        }
    }
}
