using System;
using System.Collections.Generic;
using System.Linq;

namespace T01_Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputCommands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int elementToLookFor = inputCommands[2];
            int elementsToReacive = inputCommands[0];
            int elementsToPop = inputCommands[1];
            Stack<int> stack = new Stack<int>(input);
            for (int i = 0; i < elementsToPop; i++)
            {
                if (stack.Count > 0)
                {
                    int element = stack.Pop();
                }
            }
            if (stack.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else 
            {
                  Console.WriteLine(stack.Min());
            }
        }
    }
}
