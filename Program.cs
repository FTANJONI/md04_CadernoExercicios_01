using System;

namespace md04_CadernoExercicios_01
{
    class Program
    {
        /*
         1. Construa um Algoritmo que, para um grupo de 10 valores inteiros, determine:
            a) A soma dos números positivos;
            b) A quantidade de valores negativos;
            -
         */
        static void Main(string[] args)
        {
            int n = -4, nrNegativos = 1, somaPositivos = 0;

            while (n <= 5)
            {
                if (n < 0)
                {
                    nrNegativos++;
                }
                else
                {
                    somaPositivos = somaPositivos + n;
                }

                n++;
            }

            Console.WriteLine("\nO somatório de todos os números positivos foi: " + somaPositivos.ToString());
            Console.WriteLine("A quantidade de números negativos foi: " + nrNegativos.ToString());

        }
    }
}
