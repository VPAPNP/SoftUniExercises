using System;
using System.Text;

namespace T01_Activation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StringBuilder sb = new StringBuilder(Console.ReadLine());
            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string[] commandArg = command.Split(">>>");
                string action = commandArg[0];
                if (action == "Contains")
                {
                    string subStr = commandArg[1];
                    if (sb.ToString().Contains(subStr))
                    {
                        Console.WriteLine($"{sb} contains {subStr}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string upperOrLower = commandArg[1];
                    int startIndex = int.Parse(commandArg[2]);
                    int endIndex = int.Parse(commandArg[3]);
                    string subStr = sb.ToString().Substring(startIndex,endIndex-startIndex);
                    if (upperOrLower == "Upper")
                    {
                        subStr = subStr.ToUpper();
                    }
                    else if (upperOrLower == "Lower")
                    {
                        subStr = subStr.ToLower();
                    }
                    sb.Remove(startIndex, endIndex - startIndex);
                    sb.Insert(startIndex, subStr);
                    Console.WriteLine(sb);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);
                    sb.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(sb);


                }

            }
            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
