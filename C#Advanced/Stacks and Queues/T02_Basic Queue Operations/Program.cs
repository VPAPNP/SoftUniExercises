using System;
using System.Collections.Generic;
using System.Linq;

namespace T02_Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArg = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int elementsToDeq = inputArg[1];
            int elementToLookFor = inputArg[2];
            Queue<int> queue = new Queue<int>(input);
            for (int i = 0; i < elementsToDeq; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(elementToLookFor))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(queue.Count());
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
            
        }
    }
}
