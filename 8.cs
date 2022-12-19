using System;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            do
            {
                Console.Write("введите число: ");
            } while (!Double.TryParse(Console.ReadLine(), out a));

            a = a % 2 == 0 ? a : (a - 1);

            for (int i = 2; i <= a; i += 2)
                Console.Write(i + " ");
        }
    }
}
