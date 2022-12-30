using System;
using System.Collections.Generic;
using System.Linq;

namespace T01_Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            foreach(double num in input)
            {
                if (result.ContainsKey(num))
                {
                    result[num]++;
                }
                else if (!result.ContainsKey(num))
                {
                    result.Add(num, 1);
                }
            }
            foreach(var res in result)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
