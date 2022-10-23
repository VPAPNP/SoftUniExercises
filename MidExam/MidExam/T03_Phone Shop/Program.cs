using System;
using System.Collections.Generic;
using System.Linq;

namespace T03_Phone_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command;
            while ((command = Console.ReadLine())!= "End")
            {
                string[] commandArg = command.Split(" - ",StringSplitOptions.RemoveEmptyEntries);
                if (commandArg[0] == "Add")
                {
                    if (list.Contains(commandArg[1]))
                    {
                        continue;
                    }
                    else 
                    {
                        list.Add(commandArg[1]);
                    }
                }
                else if (commandArg[0] == "Remove")
                {
                    if (list.Contains(commandArg[1]))
                    {
                        list.Remove(commandArg[1]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandArg[0] == "Bonus phone")
                {
                    string[] phones = commandArg[1].Split(':').ToArray();
                    if (list.Contains(phones[0]))
                    {
                        int index = list.IndexOf(phones[0]);
                        list.Insert(index +1, phones[1]);

                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandArg[0] == "Last")
                {
                    if (list.Contains(commandArg[1]))
                    {
                        list.Remove(commandArg[1]);
                        list.Add(commandArg[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", list));
            
        }
    }
}
