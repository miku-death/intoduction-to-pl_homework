using System;
using System.Threading;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(SumBetween(n, m));
        }

        private static int SumBetween(int n, int m)
        {
            if (n > m && n > 0)
                return n + SumBetween(n - 1, m);
            else
                return n;
        }
    }
}
