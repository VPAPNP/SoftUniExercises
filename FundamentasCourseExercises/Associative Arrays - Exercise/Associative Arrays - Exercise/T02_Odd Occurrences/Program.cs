using System;
using System.Collections.Generic;

namespace T02_Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> output = new Dictionary<string, int>();

            foreach (string line in input)
            {
                string wordToLower = line.ToLower();
                if (output.ContainsKey(wordToLower))
                {
                    output[wordToLower]++;
                }
                else
                {
                    output.Add(wordToLower, 1);
                }

            }
            foreach (var word in output)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }

            }
        }
    }
}
