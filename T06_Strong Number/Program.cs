using System;

namespace T06_Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int numCopy = num;
            int facorialSum = 0;
            while (numCopy >0)
            {
                int lastDigit = numCopy % 10;
                numCopy /= 10;
                int facturial = 1;
                for (int i = 2; i <= lastDigit; i++)
                {
                    facturial *= i;
                }
                facorialSum += facturial;
            }
            if (facorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
