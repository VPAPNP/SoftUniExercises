using System;
using System.Text;

namespace T04_Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            foreach(char c in input) 
            {
                int currentPosition = c;
                currentPosition += 3;
                sb.Append((char)currentPosition);
                
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
