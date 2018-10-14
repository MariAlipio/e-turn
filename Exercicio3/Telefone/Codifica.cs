using System;
using System.Collections.Generic;
using System.Text;

namespace Telefone
{
    class Codifica
    {
        public string[] Codificar(int[] vet)
        {
            int i;
            string[] cod = new string[vet.Length];

            for (i = 0; i < vet.Length; i++)
            {
                if (vet[i] <= 9 && vet[i] > 8)
                {
                    cod[i] = "W";
                }
                else if (vet[i] <= 8 && vet[i] > 7)
                {
                    cod[i] = "T";
                }
                else if (vet[i] <= 7 && vet[i] > 6)
                {
                    cod[i] = "P";
                }
                else if (vet[i] <= 6 && vet[i] > 7)
                {
                    cod[i] = "M";
                }
                else if (vet[i] <= 5 && vet[i] > 4)
                {
                    cod[i] = "J";
                }
                else if (vet[i] <= 4 && vet[i] > 3)
                {
                    cod[i] = "G";
                }
                else if (vet[i] <= 3 && vet[i] > 2)
                {
                    cod[i] = "D";
                }
                else if (vet[i] <= 2 && vet[i] > 1)
                {
                    cod[i] = "A";
                }
                else if (vet[i] >= 0 && vet[i] < 1)
                {
                    cod[i] = " ";
                }
                else if (vet[i] <= 1 && vet[i] > 0)
                {
                    continue;
                }

                if (vet[i] <= 99 && vet[i] > 98)
                {
                    cod[i] = "X";
                }
                else if (vet[i] <= 88 && vet[i] > 87)
                {
                    cod[i] = "U";
                }
                else if (vet[i] <= 77 && vet[i] > 76)
                {
                    cod[i] = "Q";
                }
                else if (vet[i] <= 66 && vet[i] > 65)
                {
                    cod[i] = "N";
                }
                else if (vet[i] <= 55 && vet[i] > 54)
                {
                    cod[i] = "K";
                }
                else if (vet[i] <= 44 && vet[i] > 43)
                {
                    cod[i] = "H";
                }
                else if (vet[i] <= 33 && vet[i] > 32)
                {
                    cod[i] = "E";
                }
                else if (vet[i] <= 22 && vet[i] > 21)
                {
                    cod[i] = "B";
                }

                if (vet[i] <= 999 && vet[i] > 998)
                {
                    cod[i] = "Y";
                }
                else if (vet[i] <= 888 && vet[i] > 887)
                {
                    cod[i] = "V";
                }
                else if (vet[i] <= 777 && vet[i] > 776)
                {
                    cod[i] = "R";
                }
                else if (vet[i] <= 666 && vet[i] > 665)
                {
                    cod[i] = "O";
                }
                else if (vet[i] <= 555 && vet[i] > 554)
                {
                    cod[i] = "L";
                }
                else if (vet[i] <= 444 && vet[i] > 443)
                {
                    cod[i] = "I";
                }
                else if (vet[i] <= 333 && vet[i] > 332)
                {
                    cod[i] = "F";
                }
                else if (vet[i] <= 222 && vet[i] > 221)
                {
                    cod[i] = "C";
                }
                else if (vet[i] <= 9999 && vet[i] > 9998)
                {
                    cod[i] = "Z";
                }
                else if (vet[i] <= 7777 && vet[i] > 7776)
                {
                    cod[i] = "S";
                }
                
            }

            return cod;

        }
    }
}
