using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T09_Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<string> strings= new Stack<string>();
            StringBuilder text = new StringBuilder();
            strings.Push(text.ToString());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);
                if (command == 1)
                {
                        string toApend = input[1];
                        strings.Push(toApend);
                        text.Append(toApend);
                }
                else if (command == 2) 
                {
                    int count = int.Parse(input[1]);
                    text.Remove(text.Length - count, count);
                    strings.Push(text.ToString());
                }
                else if (command == 3)
                {
                    int index = int.Parse(input[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (command == 4)
                {
                    if (strings.Count > 0)
                    {
                        strings.Pop();
                        text = new StringBuilder();
                        text.Append(strings.Peek());
                    }
                    
                }
                
            }
        }
    }
}
