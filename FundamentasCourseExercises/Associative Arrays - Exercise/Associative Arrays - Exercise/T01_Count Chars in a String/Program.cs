using System;
using System.Collections.Generic;

namespace T01_Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char , int> keyValuePairs = new Dictionary<char , int>();

            string input = Console.ReadLine();

            foreach (char ch in input)
            {
                if (ch != ' ')
                {
                    if (!keyValuePairs.ContainsKey(ch))
                    {
                        keyValuePairs.Add(ch, 0);

                    }
                    keyValuePairs[ch]++;
                }
                

            }
            foreach (KeyValuePair<char, int> ch in keyValuePairs)
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
            
        }
    }
}
