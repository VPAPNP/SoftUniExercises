using System;
using System.Linq;

namespace T01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commmand;
            while ((commmand = Console.ReadLine()) != "Done")
            {
                string[] commandArg = commmand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArg[0];
                if (action == "Change")
                {
                    string toReplace = commandArg[1];
                    string replacement = commandArg[2];
                    input = input.Replace(toReplace, replacement);
                    Console.WriteLine(input);
                }
                else if (action == "Includes")
                {
                    string substring = commandArg[1];
                    bool includes = input.Contains(substring);
                    Console.WriteLine(includes);
                }
                else if (action == "End")
                {
                    string substring = commandArg[1];
                    bool endWith = input.EndsWith(substring);
                    Console.WriteLine(endWith);
                }
                else if (action == "Uppercase")
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (action == "FindIndex")
                {
                   string toFind = commandArg[1];
                    int found = input.IndexOf(toFind);

                    Console.WriteLine(found);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int count = int.Parse(commandArg[2]);
                    string toBe = input.Substring(startIndex, count);
                    input = toBe;
                    Console.WriteLine(input);
                }
            }
        }
    }
}
