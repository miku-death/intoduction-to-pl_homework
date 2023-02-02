using System;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];

            Random r = new Random();

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    array[i, j] = r.Next();
            
            // предположим, что цисла неотрицательные
            int minSum = -1;
            int minSumRow = 0;

            for (int i = 0; i < 4; i++)
            {
                int sum = 0;

                for (int j = 0; j < 4; j++)
                    sum += array[i, j];

                if (i == 0)
                {
                    minSum = sum;
                    minSumRow = i;
                }
                else
                {
                    if (sum < minSum)
                    {
                        minSum = sum;
                        minSumRow = i;
                    }
                }
            }

            Console.WriteLine($"{minSumRow+1} строка");
        }
    }
}
