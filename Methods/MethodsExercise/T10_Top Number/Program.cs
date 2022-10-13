using System;

namespace T10_Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            PrintTopIntegers(h);
        }
        static void PrintTopIntegers(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (IsDevisibleByEight(i) && IsInItOddDigit(i) )
                {
                    Console.WriteLine(i);
                }
            }
            
            

        }
        static bool IsDevisibleByEight(int num)
        {
            int digitSum = 0;
            while (num > 0)
            {
                digitSum += num % 10;
                num /= 10;
            }
            if (digitSum % 8 == 0)
            {
                return true;
            }
            return false;


        }
        static bool IsInItOddDigit(int num)
        {
            while (num > 0)
            {
                if ((num % 10)%2 == 1)
                {
                    return true;
                }
                num /= 10;
                
            }
            return false;
        }
    }
}
