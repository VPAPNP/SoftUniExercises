using System;
using System.Collections.Generic;
using System.Transactions;

namespace T04_SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int num  = int.Parse(Console.ReadLine());
            Dictionary<string, string> registry = new Dictionary<string, string>();

            for (int i = 0; i < num; i++)
            {
                string command = Console.ReadLine();
                string[] commandInfo = command.Split(" ");
                string action = commandInfo[0];
                string username = commandInfo[1];
                if (action == "register")
                {
                    string licensePlNum = commandInfo[2];
                    if (!registry.ContainsKey(username))
                    {
                        registry.Add(username, licensePlNum);
                        Console.WriteLine($"{username} registered {registry[username]} successfully"); 
                    }
                    else if (registry.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registry[username]}");
                    }
                }
                else if (action == "unregister")
                {
                    if (!registry.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registry.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }
            foreach (var item in registry)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
