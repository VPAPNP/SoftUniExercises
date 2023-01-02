using System;
using System.Collections.Generic;
using System.Linq;

namespace T05_Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] colthes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rackCapacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(colthes);
            int numRacks = 1;
            int capacity = rackCapacity;
            
            while (stack.Count > 0)
            {
                int cuurent = stack.Peek();
                if (capacity >= cuurent)
                {
                    capacity -= cuurent;
                    stack.Pop();
                }
                else
                {
                     numRacks++;
                    capacity = rackCapacity;
                }
            }
            Console.WriteLine(numRacks);


        }
    }
}
