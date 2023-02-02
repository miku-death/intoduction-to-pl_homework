using System;
using System.Threading;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[8];
            int[,,] array = new int[2, 2, 2];

            Random r = new Random();

            for(int i = 0; i < 2; i++)
                for(int j = 0; j < 2; j++)
                    for(int k = 0; k < 2; k++)
                    {
                        int number = r.Next(10, 100);
                        while(!FindInArray(number, numbers))
                            number = r.Next(10, 100);
                        array[i, j, k] = number;
                    }

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        Console.WriteLine($"{array[i, j, k]} ({i},{j},{k})");
        }

        static bool FindInArray(int number, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                if (number == numbers[i]) return true;
            return false;
        }
    }
}
