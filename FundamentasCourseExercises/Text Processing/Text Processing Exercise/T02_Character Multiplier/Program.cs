using System;

namespace T02_Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            
            string strFirst = input[0];
            string strSecond = input[1];
            Console.WriteLine(MultiplySum(strFirst,strSecond));

        }

        private static int MultiplySum(string strFirst, string strSecond)
        {
            int result = 0;


            if (strFirst.Length < strSecond.Length)
            {
                for (int i = 0; i < strFirst.Length; i++)
                {
                    char first = strFirst[i];
                    char second = strSecond[i];
                    result += first * second;
                }
                for (int i = strFirst.Length ; i < strSecond.Length ; i++)
                {
                    result += strSecond[i];

                }

            }
            else if (strFirst.Length > strSecond.Length)
            {
                for (int i = 0; i < strSecond.Length; i++)
                {
                    char first = strFirst[i];
                    char second = strSecond[i];
                    result += first * second;
                }
                for (int i = strSecond.Length ; i < strFirst.Length ; i++)
                {
                    result += strFirst[i];

                }
            }
            else if (strFirst.Length == strSecond.Length)
            {
                for (int i = 0; i < strSecond.Length; i++)
                {
                    char first = strFirst[i];
                    char second = strSecond[i];
                    result += first * second;
                }
            }
              return result;
        }
    }
}
