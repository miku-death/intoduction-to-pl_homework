using System;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            do
            {
                Console.Write("введите первое число: ");
            } while (!Double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("введите второе число: ");
            } while (!Double.TryParse(Console.ReadLine(), out b));

            Console.WriteLine($"max = {(a > b ? a : b)}");
        }
    }
}
