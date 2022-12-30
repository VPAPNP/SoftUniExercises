using System;
using System.Runtime.InteropServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace T06_Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = PrintMidlleOfString(text);
            Console.WriteLine(text);
            
        }
        static string PrintMidlleOfString(string text)
        {
            char[] chars = text.ToCharArray();
            string newRes = " ";
            int charCount = chars.Length;
            if (charCount % 2 == 0)
            {
                char[] resultOne = new char[2];
                resultOne[0] = chars[(charCount / 2) - 1];
                resultOne[1] = chars[charCount / 2];
                newRes = new string(resultOne);
            }
            else
            {
                char[] resultOne = new char[1];
                resultOne[0] = chars[charCount /2];
                
                newRes = new string(resultOne);
            }
            
            return newRes;
        }
    }
}
