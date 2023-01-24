using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int[] line1 = InputArray();
            int[] line2 = InputArray();

            // x = (b2 - b1)/(k2 - k1)
            double x = (line2[1] - line1[1])/(line1[0] - line2[0]);
            // подставляем х в одно из уравнений
            double y = line1[0]*x + line1[1];

            Console.WriteLine($"({x},{y})");
        }

        static public int[] InputArray()
        {
            int[] a = new int[2];

            Console.WriteLine("k = ");
            a[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b = ");
            a[1] = Convert.ToInt32(Console.ReadLine());

            return a;
        }
    }
}