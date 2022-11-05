using System;
using System.Collections.Generic;

namespace T07_Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(" -> ");
                string companyName = info[0];
                string empId = info[1];
                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                    companyUsers[companyName].Add(empId);
                }
                else
                {
                    if (!companyUsers[companyName].Contains(empId))
                    {
                        companyUsers[companyName].Add(empId);
                    }
                }
            }
            foreach(var item in companyUsers)
            {
                List<string> users = item.Value;
                Console.WriteLine($"{item.Key}");
                foreach (var user in users)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}
