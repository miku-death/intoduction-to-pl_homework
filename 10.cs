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
                do
                {
                    Console.Write("введите число: ");
                } while (!Double.TryParse(Console.ReadLine(), out a));
            } while (a < 100 || a > 999);

            Console.WriteLine(a % 100);
        }
    }
}
