using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace T03_House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numComands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < numComands; i++)
            {
                string[] comands = Console.ReadLine().Split();
                if (!comands.Contains("not"))
                {
                    if (!guests.Contains(comands[0]))
                    {
                        guests.Add(comands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{comands[0]} is already in the list!");
                    }
                    
                }
                else if(comands.Contains("not"))
                {
                    if (guests.Contains(comands[0]))
                    {
                        guests.Remove(comands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{comands[0]} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, guests));
        }
    }
}
