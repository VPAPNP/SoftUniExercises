using System;
using System.Linq;

namespace T06_Equal_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            foreach (int i in array)
            {
                

                for (int j = 0; j < array.Length; j++)
                {
                     sumRight =+i;
                    Console.WriteLine(sumRight);
                    Console.WriteLine("Right---------------------");
                }
                

                for (int c = array.Length; c > i; c--)
                {
                    sumLeft = +i;
                    Console.WriteLine(sumLeft);
                    Console.WriteLine("Left+++++++++++++++++++++");
                }

                if (sumLeft == sumRight)
                {
                    Console.WriteLine();
                }
               

            }
            
            
                

        }
    }
}
