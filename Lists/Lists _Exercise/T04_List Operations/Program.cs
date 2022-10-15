using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace T04_List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string comands;
            while ((comands = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = comands.Split();
                if (cmdArgs.Contains("Add"))
                {
                    ints.Add(int.Parse(cmdArgs[1]));
                }
                else if (cmdArgs.Contains("Insert"))
                {
                    int index = int.Parse(cmdArgs[2]);
                    if (index < 0 || index > ints.Count )
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ints.Insert(index, int.Parse(cmdArgs[1]));
                    }
                }
                else if (cmdArgs.Contains("Remove"))
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index > ints.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        ints.RemoveAt(index);
                    }
                }
                else if (cmdArgs.Contains("left"))
                {
                    int count = int.Parse(cmdArgs[2]);

                    for (int i = 0; i < count; i++)
                    {
                        int firstNum = ints[0];
                        ints.RemoveAt(0);
                        ints.Add(firstNum);
                    }
                }
                else if (cmdArgs.Contains("right"))
                {
                    int count = int.Parse(cmdArgs[2]);
                    int lastNum = ints[ints.Count - 1];
                    for (int i = 0; i < count; i++)
                    {
                        ints.RemoveAt(ints.Count -1);
                        ints.Insert(0, lastNum);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
