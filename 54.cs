using System;

namespace gb
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];

            Random r = new Random();

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    array[i, j] = r.Next();

            for(int i = 0; i < 4; i++)
            {
                int[] subArray = new int[4];
                for(int j = 0; j < 4; j++)
                    subArray[j] = array[i, j];
                Array.Sort(subArray);
                Array.Reverse(subArray);
                for (int j = 0; j < 4; j++)
                    array[i, j] = subArray[j];
            }
        }
    }
}
