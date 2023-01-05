using System;
using System.Collections.Generic;
using System.Linq;

namespace T08_Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> charsInput= new Stack<char>();
            
            foreach (var item in input)
            {
                if (charsInput.Any())
                {
                    char curr = charsInput.Peek();
                    if (curr == '{' && item == '}')
                    {
                        charsInput.Pop();
                        continue;
                    }
                    else if (curr == '[' && item == ']')
                    {
                        charsInput.Pop();
                        continue;
                    }
                    else if (curr == '(' && item == ')')
                    {
                        charsInput.Pop();
                        continue;
                    }
                    

                }
                charsInput.Push(item);
            }
                
            if (charsInput.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            
        }
    }
}
