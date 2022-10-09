using System;

namespace T03_Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char[] charsBetween = (char[])PrintBetweenChar(first, second);
            foreach (char c in charsBetween)
            {
                Console.Write(c + " ");
            }
        }
        static Array PrintBetweenChar(char first, char second)
        {
            int firstChar = (int)first;
            int secondChar = (int)second;
            int firstCharU = (int)first;
            if (firstChar > secondChar)
            {
                firstChar = (int)second;
                secondChar = (int)firstCharU;
            }
            char currenChar = ' ';
            int arraySize = secondChar - firstChar - 1;
            char[] chars = new char[arraySize];
            
            for (int i = firstChar + 1; i < secondChar; i++)
            {
                currenChar = (char)i;
                chars[i - firstChar - 1] = currenChar;
               
            }
            return chars;

        }
    }
      
}