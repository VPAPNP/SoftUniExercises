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
            char[] chars = input.ToCharArray();
            Queue<char> left= new Queue<char>();
            Stack<char> right= new Stack<char>();
            for (int i = 0; i < chars.Length/2; i++)
            {
                left.Enqueue(chars[i]);
            }
            for (int i = chars.Length/2; i < chars.Length; i++)
            {
                right.Push(chars[i]);
            }
            for (int i = 0; i < right.Count; i++)
            {
                char leftChar = left.Dequeue();
                char rightChar = right.Pop();
                if (leftChar != rightChar)
                {
                    Console.WriteLine("NO");
                    break;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
