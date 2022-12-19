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
                Console.Write("введите число: ");
            } while (!Int32.TryParse(Console.ReadLine(), out a));

            if (a < 100) Console.WriteLine("нет третьего числа");
            else
            {
                while (a > 999)
                    a /= 10;
                Console.WriteLine(a % 10);
            }
        }
    }
}
