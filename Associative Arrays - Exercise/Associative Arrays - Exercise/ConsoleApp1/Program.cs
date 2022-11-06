using System;
using System.Collections.Generic;

namespace T03_WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
          for (int i = 0; i < num; i++)
          {

                 string wordKey=Console.ReadLine();
                 string wordValue = Console.ReadLine();
                if (words.ContainsKey(wordKey))
                {
                    words[wordKey].Add(wordValue);
                }
                else
                {
                    words.Add(wordKey, new List<string>());
                    words[wordKey].Add(wordValue);
                }
                
            
            
          }
            foreach (var item in words)
            {
                List<string> strings = item.Value;
                Console.WriteLine($"{item.Key} - {string.Join(", ", strings)}");
            }
        }
    }
}
