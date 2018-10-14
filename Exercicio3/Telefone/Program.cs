using System;

namespace Telefone
{
    class Program
    {
        static void Main(string[] args)
        {
            var vet = new int[] { 33, 8, 88, 777, 66, 0, 9, 33, 22, 0, 33, 0, 7777, 666, 333, 8, 9, 2, 777, 33, 0, 7777, 666, 555, 88, 8, 444, 666, 66 };

            Codifica C = new Codifica();

            string[] VetorCodificado = C.Codificar(vet);

            Console.WriteLine(" O texto contido na string é:");
            for (int x = 0; x < VetorCodificado.Length; x++)
            {
                Console.Write(VetorCodificado[x]);
            }
            Console.ReadKey();

        }
    }
}
