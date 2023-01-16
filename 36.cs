using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int[] a = GenerateNumbers(5);
            Console.WriteLine(SumOdd(a));
        }

        private static int SumOdd(int[] a)
        {
            int result = 0;

            for(int i = 0; i < a.Length; i+=2)
            {
                result += a[i];
            }

            return result;
        }

        private static int[] GenerateNumbers(int v)
        {
            int[] a = new int[v];

            Random r = new Random();

            for(int i = 0; i < v; i++)
                a[i] = r.Next(int.MinValue, int.MaxValue);

            return a;
        }
    }
}