using System;
using System.Threading;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] spiral = new int[5,5];

            int numberToAdd = 1;

            int i = 0;
            int j = 0;

            int iAdd = 0;
            int jAdd = 1;

            while(numberToAdd <= spiral.GetLength(0) * spiral.GetLength(1))
            {
                spiral[i, j] = numberToAdd++;

                i += iAdd;
                j += jAdd;

                if ((i == -1 || i == spiral.GetLength(0)) && (iAdd != 0))
                {
                    jAdd = -iAdd;
                    i -= iAdd;
                    iAdd = 0;
                    j += jAdd;
                }
                else if ((j == -1 || j == spiral.GetLength(1)) && (jAdd != 0))
                {
                    iAdd = jAdd;
                    j -= jAdd;
                    jAdd = 0;
                    i += iAdd;
                }
                else if ((spiral[i, j] != 0) && (iAdd != 0))
                {
                    jAdd = -iAdd;
                    i -= iAdd;
                    iAdd = 0;
                    j += jAdd;
                }
                else if (spiral[i, j] != 0 && (jAdd != 0))
                {
                    iAdd = jAdd;
                    j -= jAdd;
                    jAdd = 0;
                    i += iAdd;
                }
            }

            Print(spiral);
        }

        static void Print(int[,] array)
        {
            for(int i = 0; i< array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write($"{array[i, j]:d2} ");
                Console.Write('\n');
            }
        }
    }
}
