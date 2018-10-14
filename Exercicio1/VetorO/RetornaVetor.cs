using System;
using System.Collections.Generic;
using System.Text;

namespace VetorO
{
    class RetornaVetor
    {
        //Função que retorna um vetor ordenado com os inteiros dos dois vetores
        public int[] Retorna(int[] V1, int[] V2)
        {
            int i, j = 0, k = 0;

            int[] V3 = new int[V1.Length + V2.Length];

            for (i = 0; i < V3.Length; i++)
            {
                if (j >= V1.Length)
                {
                    V3[i] = V2[k];
                    k = k + 1;
                    continue;
                }
                if (k >= V2.Length)
                {
                    V3[i] = V1[j];
                    j = j + 1;
                    continue;
                }
                if (V1[j] <= V2[k])
                {
                    V3[i] = V1[j];
                    j = j + 1;
                }
                else
                {
                    V3[i] = V2[k];
                    k = k + 1;
                }

            }
            return V3;
        }
    }
}
