using System;
using System.Collections.Generic;
using System.Text;

namespace Vetores
{
    class Compara
    {
        //Função que ordena do menor para o maior
        public int[] RetornaSegundoMaior(int[] meuvet)
        {
            for (int i = 0; i < meuvet.Length; i++)
            {
                for (int j = 0; j < meuvet.Length - 1 - i; j++)
                {
                    if (meuvet[j] > meuvet[j + 1])
                    {
                        int aux = meuvet[j + 1];
                        meuvet[j + 1] = meuvet[j];
                        meuvet[j] = aux;
                    }
                }
            }
            return meuvet;
        }
    }
}
