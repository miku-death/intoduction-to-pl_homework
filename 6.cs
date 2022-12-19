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

            Console.WriteLine((a % 2 == 0) ? "да" : "нет");
        }
    }
}
