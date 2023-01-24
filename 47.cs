using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] a = new double[m,n];

            Random r = new Random();

            for(int i = 0; i < m; i++)
                for(int j = 0; j < n; j++)
                {
                    a[m, n] = r.Next() + r.NextDouble();
                }
        }
    }
}