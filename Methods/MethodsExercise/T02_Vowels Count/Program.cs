using System;
using System.Linq;

namespace T02_Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string e = Console.ReadLine();
            int vowelsCount = GetVowelsCount(e);
            Console.WriteLine(vowelsCount);
        }
        static int GetVowelsCount(string text)
        {
            int vowelsCount = 0;
            char[] vowels = new char[] { 'a', 'e', 'o', 'u', 'i', 'y' };
            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
