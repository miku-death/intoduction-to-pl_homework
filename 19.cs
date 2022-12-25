using System;

namespace Homework
{
    class Program
    {
        static public void Main()
        {
            Console.WriteLine("enter number: ");
            string s = Console.ReadLine();
            Console.WriteLine(PalidromeCheck(s));
            Console.Read();
        }

        static bool PalidromeCheck(string s)
        {
            int i = 0;
            int j = s.Length - 1;

            while(i < s.Length)
            {
                if(s[i] != s[j])
                    return false;

                i++;
                j--;
            }
            
            return true;
        }
    }
}