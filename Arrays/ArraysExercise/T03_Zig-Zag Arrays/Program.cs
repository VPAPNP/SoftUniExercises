using System;
using System.Linq;

namespace T03_Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] first = new int[n];
            int[] second = new int[n];
            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                int firstNum = numbers[0];
                int secondNum = numbers[1];
                if( i % 2 != 0 )
                {
                    first[i -1] = firstNum;
                    second[i -1] = secondNum;
                }
                else
                {
                    first[i-1] = secondNum;
                    second[i - 1] = firstNum;
                }

            }
            Console.WriteLine(String.Join(" ", first));
            Console.WriteLine(String.Join(" ", second));
        }
    }
}
