using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int m = 4;
            int n = 4;
            int[,] a = new int[m,n];

            Random r = new Random();

            for(int i = 0; i < m; i++)
                for(int j = 0; j < n; j++)
                {
                    a[m,n] = r.Next();
                }

            Average(a);
        }

        private static double[] Average(int[,] a)
        {
            double[] result = new double[a.GetLength(1)];

            for(int i = 0; i < result.Length; i++)
                result[i] = 0;

            for(int i = 0; i < a.GetLength(0); i++)
                for(int j = 0; j < a.GetLength(1); j++)
                    result[j] += a[i, j];
            
            for(int i = 0; i < result.Length; i++)
                result[i] /= a.GetLength(0);

            return result;
        }
    }
}