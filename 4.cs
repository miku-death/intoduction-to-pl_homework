using System;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b,c ;

            do
            {
                Console.Write("введите первое число: ");
            } while (!Double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("введите второе число: ");
            } while (!Double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.Write("введите второе число: ");
            } while (!Double.TryParse(Console.ReadLine(), out c));

            Console.WriteLine($"max = {(a > b ? (a > c ? a : c) : (b > c ? b : c))}");
        }
    }
}
