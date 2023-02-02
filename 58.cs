using System;
using System.Threading;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[4, 4];
            int[,] array2 = new int[4, 4];

            Random r = new Random();

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    array1[i, j] = r.Next(-10000, 10000);
                    //увеличение рандомности чисел
                    Thread.Sleep(5);
                    array2[i, j] = r.Next();
                }

            int[,] result = new int[4, 4];

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    result[i, j] = 0;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        result[i, j] += array1[i, k] * array2[k, j];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(result[i, j]);
                Console.Write('\n');
            }
        }
    }
}
