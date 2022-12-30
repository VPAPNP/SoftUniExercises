using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace T01_PasswoReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command;
            StringBuilder sb = new StringBuilder();
            sb.Append(input);
            while ((command = Console.ReadLine())!= "Done")
            {
                string[] commandArg = command.Split(' ');
                string action = commandArg[0];
                
                if (action == "TakeOdd")
                {
                    input = sb.ToString();
                    sb.Clear();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i %2 != 0)
                        {
                            sb.Append(input[i]);
                        }
                    }
                    Console.WriteLine(sb);
                }
                else if (action == "Cut")
                {
                   
                    int index = int.Parse(commandArg[1]);
                    int lenght = int.Parse(commandArg[2]);
                   sb.Remove(index, lenght);
                    Console.WriteLine(sb);
                }
                else if (action == "Substitute")
                {
                    string substring = commandArg[1];
                    string substitute = commandArg[2];
                    if (sb.ToString().Contains(substring))
                    {
                       sb.Replace(substring, substitute);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {sb}");
        }
    }
}
