using System;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(DigitsSum(number));
            Console.Read();
        }

        static public int DigitsSum(int number)
        {
            int result = 0;
            while(number > 0)
            {
                result += number % 10;
                number /= 10;
            }
            return result;
        }
    }
}