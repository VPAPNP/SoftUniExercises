using System;
using System.Collections.Generic;
using System.Linq;
namespace T02_Shopping_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()  
                   .Split('!')
                   .ToList();
            string command;
            

            while ((command = Console.ReadLine()) != "Go Shopping!")
            {
                string[] commandArg = command.Split(' ');
                string priority = commandArg[0];
                string item = commandArg[1];
              
                if (commandArg[0] == "Urgent")
                {
                    if (groceries.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (commandArg[0] == "Unnecessary")
                {
                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandArg[0] == "Correct")
                {
                    string oldItem = commandArg[1];
                    string newItem = commandArg[2];
                    if (groceries.Contains(oldItem))
                    {
                        int index = groceries.IndexOf(oldItem);
                        
                        groceries[index] = newItem;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commandArg[0] == "Rearrange")
                {
                    if (groceries.Contains(item))
                    {
                        int index = groceries.IndexOf(item);
                        groceries.RemoveAt(index);
                        groceries.Add(item);

                    }
                }


            }
            
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
