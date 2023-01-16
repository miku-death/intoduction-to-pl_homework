using System.Linq;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            string input = Console.ReadLine();
            PrintArray(input);
            Console.Read();
        }

        static public void PrintArray(string input)
        {
            string[] subResult = input.Split(", ");
            Console.Write("[");
            for(int i = 0; i < subResult.Length; i++)
                Console.Write(subResult.Length - i == 1 ? subResult[i] : subResult[i] + ", ");
            Console.Write("]");
        }
    }
}