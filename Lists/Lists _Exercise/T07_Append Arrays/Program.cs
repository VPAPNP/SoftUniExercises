using System;
using System.Collections.Generic;
using System.Linq;

namespace T07_Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> ints = Console.ReadLine()
                   .Split('|', StringSplitOptions.RemoveEmptyEntries)
                   .Reverse()
                   .ToList();
            List<int> current = new List<int>();
            List<int> ints2 = new List<int>();

            for (int i = 0; i < ints.Count; i++)
            {
                current = ints[i].Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int k = 0; k < current.Count; k++)
                {
                    ints2.Add(current[k]);
                }
                
            }
            
            Console.WriteLine(String.Join(' ', ints2));
            
        }
    }
}
