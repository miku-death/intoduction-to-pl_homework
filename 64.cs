using System;
using System.Threading;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            PrintNatural(n);
        }

        private static void PrintNatural(int n)
        {
            if (n > 0)
            {
                Console.Write($"{n} ");
                PrintNatural(n - 1);
            }
        }
    }
}
