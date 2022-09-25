using System;

namespace T04_Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = first; i <= second; i++)
            {
                if (i == second)
                {
                    Console.WriteLine($"{i} ");
                    sum = sum + i;
                }
                else
                {
                    Console.Write($"{i} ");
                    sum = sum + i;
                }
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
