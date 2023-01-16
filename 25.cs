using System;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number}^{power} = {Power(number, power)}");
            Console.Read();
        }

        static public int Power(int number, int power)
        {
            int result = 1;

            for(int i = 0; i < power; i++)
                result *= number;

            return result;
        }
    }
}