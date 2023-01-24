using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int m = Convert.ToInt32(Console.ReadLine());

            CountPositive(m);
        }

        // Решение массивом, сложность О(2n). Сложность линейная, как и во втором способе, но из-за прохождения массива дважды, медленнее работает.
        static public int CountPositive(int m)
        {
            int result = 0;
            int[] a = new int[m];

            for(int i = 0; i < m; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < a.Length; i++)
                if(a[i] > 0)
                    result++;

            return result;
        }

        static public int CountPositiveSecond(int m)
        {
            int result = 0;
            for(int i = 0; i < m; i++)
                if(Convert.ToInt32(Console.ReadLine()) > 0)
                    result++;
            return result;
        }
    }
}