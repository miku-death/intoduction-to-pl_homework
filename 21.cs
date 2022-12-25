/*
using System;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            double[] x = new double[3];
            double[] y = new double[3];

            Console.WriteLine("enter x: ");
            for(int i = 0; i < 3; i++)
            {
                x[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("enter y: ");
            for(int i = 0; i < 3; i++)
            {
                y[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"p(x, y) = {Distance(x, y)}");
            Console.Read();
        }

        private static object Distance(double[] x, double[] y)
        {
            double z1 = (x[0] - y[0])*(x[0] - y[0]);
            double z2 = (x[1] - y[1])*(x[1] - y[1]);
            double z3 = (x[2] - y[2])*(x[2] - y[2]);

            return Math.Sqrt(z1 + z2 + z3);
        }
    }
}
*/