using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = "(!)(?<command>[A-Z][a-z]{3,})\\1:(\\[)(?<message>[A-Za-z]+)(\\])";
            Regex regex= new Regex(pattern);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                   
                    string command = match.Groups["command"].Value;
                    string message = match.Groups["message"].Value;
                    List<int> ints= new List<int>();
                    foreach (var item in message)
                    {
                        char cuurn = item;
                        int num = (int)cuurn;
                        ints.Add(num);
                    }
                    Console.Write($"{command}: ");
                    Console.WriteLine(string.Join(" ", ints));
                }
                else
                {
                    Console.WriteLine($"The message is invalid");
                }
            }
        }
    }
}
