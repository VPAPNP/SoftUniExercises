using System;
using System.Text;

namespace T06_Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            char prev = input[0];
            Console.Write(prev);
            foreach (var item in input)
            {
                char curr = item;
                if (item != prev)
                {
                    prev = curr;
                    Console.Write(prev);
                }
                 
                
                
            }

           
        }
    }
}
