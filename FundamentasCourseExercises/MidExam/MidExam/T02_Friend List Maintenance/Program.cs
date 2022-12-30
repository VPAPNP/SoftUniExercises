using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace T02_Friend_List_Maintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command;
            int lost = 0;
            int blacklisted = 0;

            while ((command = Console.ReadLine())!= "Report")
            {
                string[] commandArg = command.Split(' ').ToArray();
                
                
                if (commandArg[0] == "Blacklist")
                {
                    if (list.Contains(commandArg[1]))
                    {
                        int index = list.IndexOf(commandArg[1]);
                        string name = list[index];
                        if (list.Contains(name))
                        {


                            Console.WriteLine($"{name} was blacklisted.");
                            list.RemoveAt(index);
                            list.Insert(index, "Blacklisted");
                            blacklisted++;
                        }
                        
                    }
                    else
                    {
                        string name = commandArg[1];
                        Console.WriteLine($"{name} was not found.");

                    }



                }
                else if (commandArg[0]== "Error")
                {
                    int index = int.Parse(commandArg[1]);
                    
                    if (index >= 0 && index < list.Count  && list[index] != "Blacklisted" && list[index] != "Lost")
                    {
                        string name = list[index];
                        Console.WriteLine($"{name} was lost due to an error.");
                        list[index] = "Lost";
                        lost++;
                    }
                    continue;
                    
                }
                else if (commandArg[0] == "Change")
                {
                    int index = int.Parse (commandArg[1]);
                    
                    if (index >= 0 && index < list.Count )
                    {
                        string cuurnName = list[index];
                        string newName = commandArg[2];
                        Console.WriteLine($"{cuurnName} changed his username to {newName}.");
                        list.RemoveAt (index);
                        list.Insert(index,newName);
                    }
                    continue;
                }
                
            }
            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(' ',list));
        }
    }
}
