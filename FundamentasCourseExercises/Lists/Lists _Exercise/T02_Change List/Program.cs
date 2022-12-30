using System;
using System.Collections.Generic;
using System.Linq;

namespace T02_Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "end" )
            {
                string[] cmdArg = command.Split();
                if (cmdArg.Contains("Delete"))
                {
                    int element = int.Parse(cmdArg[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (element == list[i])
                        {
                            list.RemoveAt(i);
                        }
                    }

                }
                else if(cmdArg.Contains("Insert"))
                {
                    int element = int.Parse(cmdArg[1]);
                    int position = int.Parse (cmdArg[2]);
                    list.Insert(position, element);
                }
            }
            Console.WriteLine(String.Join(" ", list));
        }
       
    }
}
