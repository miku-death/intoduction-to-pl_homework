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

            int number = Convert.ToInt32(Console.ReadLine());
            FindInArray(a, number);
        }

        private static bool FindInArray(int[,] a, int number)
        {
            for(int i = 0; i < a.GetLength(0); i++)
                for(int j = 0; j < a.GetLength(1); j++)
                    if(a[i,j] == number)
                        return true;
            return false;
        }
    }
}