using System;
using System.Linq;

namespace T01__Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = new int[3];
                
            arrayInput[0] = int.Parse(Console.ReadLine());
            arrayInput[1] = int.Parse(Console.ReadLine());
            arrayInput[2] = int.Parse(Console.ReadLine());
                
            int smalest = PrintSmallestNum(arrayInput);
            Console.WriteLine(smalest);
        }
        static int PrintSmallestNum(int[] array)
        {
            int smallest = int.MaxValue;
            int currentNum = 0;
            for (int i = 0; i < array.Length; i++)
            {
               currentNum = array[i];
                if (currentNum < smallest)
                {
                    smallest = currentNum;
                }

            }
            return smallest;
        }
    }
}
