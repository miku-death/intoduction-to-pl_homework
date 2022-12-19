using System;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            do
            {
                do
                {
                    Console.Write("введите число: ");
                } while (!Int32.TryParse(Console.ReadLine(), out a));
            } while (a < 0 || a > 7);

            Console.WriteLine(a >= 6 ? "да" : "нет");
        }
    }
}
