using System;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
                Console.WriteLine($"{i}^3 = {i*i*i}");

            Console.Read();
        }
    }
}