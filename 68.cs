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

            Console.WriteLine(A(n, m));
        }

        static int A(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
                if ((n != 0) && (m == 0))
                    return A(n - 1, 1);
                else
                    return A(n - 1, A(n, m - 1));
        }
    }
}
