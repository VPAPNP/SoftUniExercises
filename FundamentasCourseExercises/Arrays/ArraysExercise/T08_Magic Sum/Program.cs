using System;
using System.Linq;

namespace T08_Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                     .ToArray();
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < inputArray.Length -1; i++)
            {
                int sum = inputArray[i];
                for (int j = 0; j < inputArray.Length; j++)
                {
                    
                    if (sum + inputArray[j] == num)
                    {
                        Console.WriteLine($"{sum} {inputArray[i]} ");
                    }
                }
                
            }
        }
    }
}
