using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            double[] a = GenerateNumbers(5);
            Console.WriteLine(MaxMinDiff(a));
        }

        private static double MaxMinDiff(double[] a)
        {
            double max = a[0];
            double min = a[0];

            for(int i = 0; i < a.Length; i+=2)
            {
                if(a[i] > max)
                    max = a[i];
                if(a[i] < min)
                    min = a[i];
            }

            return max - min;
        }

        private static double[] GenerateNumbers(int v)
        {
            double[] a = new double[v];

            Random r = new Random();

            for(int i = 0; i < v; i++)
                a[i] = r.NextDouble() * r.Next(int.MinValue, int.MaxValue);

            return a;
        }
    }
}