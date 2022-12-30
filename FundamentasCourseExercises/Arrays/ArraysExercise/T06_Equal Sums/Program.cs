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
            bool isTrue = false;
            foreach (int i in array)
            {
                sumLeft += i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                sumLeft -= array[i];
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(i);
                    isTrue = true;
                }
                sumRight += array[i];
            }
            if (isTrue == false)
            {
                Console.WriteLine("no");
            }
            
            
            
            
            
               

            
            
            
                

        }
    }
}
