using System;
using System.Collections.Generic;
using System.Linq;

namespace T03_Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
               int numQuery = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < numQuery; i++)
            {
                int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int command = input[0];

                if (command == 1)
                {
                    int num = input[1];
                    stack.Push(num);
                }
                else if (command == 2)
                {
                    stack.Pop();

                }
                else if (command == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if(command == 4 && stack.Count > 0) 
                {
                    Console.WriteLine(stack.Min());
                }
            }
            if (stack.Count > 0)
            {
                Console.WriteLine(string.Join(", ", stack));
            }
            
        }
    }
}
