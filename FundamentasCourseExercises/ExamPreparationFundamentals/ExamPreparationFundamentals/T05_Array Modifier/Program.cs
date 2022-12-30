using System;
using System.Data;
using System.Linq;

namespace T05_Array_Modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command;
            int[] modifiedArray = new int[input.Length];
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArg = command.Split(' ');
                if (commandArg[0] == "swap")
                {
                    int firstIndex = int.Parse (commandArg[1]);
                    int secondIndex = int.Parse (commandArg[2]);
                    int valueToSecondIndex = input[secondIndex];
                    input[secondIndex] = input[firstIndex];
                    input[firstIndex] = valueToSecondIndex;
                    
                }
                else if (commandArg[0] == "multiply")
                {
                    int firstIndex = int.Parse(commandArg[1]);
                    int secondIndex = int.Parse(commandArg[2]);
                    int production = input[firstIndex] * input[secondIndex];
                    input[firstIndex] = production;
                }
                else if (commandArg[0] == "decrease")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        input[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
