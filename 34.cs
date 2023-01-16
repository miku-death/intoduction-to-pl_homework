using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int[] a = GenerateNumbers(5);
            Console.WriteLine(CountEvent(a));
        }

        private static int CountEvent(int[] a)
        {
            int result = 0;
            foreach(int n in a)
                if(n % 2 == 0)
                    result++;

            return result;
        }

        private static int[] GenerateNumbers(int v)
        {
            int[] a = new int[v];

            Random r = new Random();

            for(int i = 0; i < v; i++)
            {
                int n = r.Next();
                while(n == 0)
                    n = r.Next();
                a[i] = n;
            }

            return a;
        }
    }
}