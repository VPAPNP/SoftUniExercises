using System;
using System.Collections.Generic;
using System.Linq;

namespace T01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine())!= "end")
            {
                string[] cmd = command
                    .Split(' ');
                if (cmd.Contains("Add"))
                {
                    
                    int cmdValue = int.Parse (cmd[1]);
                    input.Add(cmdValue);

                }
                else 
                {
                    int passengersToGet = int.Parse(cmd[0]);
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (passengersToGet + input[i] <= capacity)
                        {
                            int sum = passengersToGet + input[i];
                            input.RemoveAt(i);
                            input.Insert(i, sum);
                            break;
                        }
                    }
                }
                
                

            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
