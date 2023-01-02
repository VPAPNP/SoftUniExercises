using System;
using System.Collections.Generic;
using System.Linq;

namespace T04_Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int orderTotalQuantity = int.Parse(Console.ReadLine());
            int[] ordersCount = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            int biggest = int.MinValue;
            
            for (int i = 0; i < ordersCount.Length; i++)
            {
                queue.Enqueue(ordersCount[i]);
                int cuurent = queue.Peek();
                if (cuurent > biggest)
                {
                    biggest = cuurent;
                }
                if (orderTotalQuantity >= cuurent)
                {
                    queue.Dequeue();
                    orderTotalQuantity -= cuurent;
                    
                }
            }
            
            Console.WriteLine(biggest);
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }

        }
    }
}
