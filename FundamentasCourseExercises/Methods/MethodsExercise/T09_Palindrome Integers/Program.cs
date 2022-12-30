using System;

namespace T09_Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = string.Empty;
            PalindromeIntegers(text);
        }
        static void PalindromeIntegers(string text)
        {
            string reversed = string.Empty;

            while (text != "END")
            {
                text = Console.ReadLine();
                if (text == "END")
                {
                    break;
                }
                for (int i = text.Length -1; i >= 0; i--)
                {
                    reversed += text[i];
                }
                if (text == reversed)
                {
                    Console.WriteLine("true");
                }
                else if (text!= reversed)
                {
                    Console.WriteLine("false");
                }
                reversed = String.Empty;

            }

            
           
        }
    }
}
