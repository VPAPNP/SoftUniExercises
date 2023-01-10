using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double,int> values= new Dictionary<double,int>();
            double[] value = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < value.Length; i++)
            {
                double curr = value[i];
                if (!values.ContainsKey(curr))
                {
                    values.Add(curr, 1);
                }
                else
                {
                    values[curr]++;
                }
            }
            foreach (var item in values)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
