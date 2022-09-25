using System;

namespace T08_Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int yieldSum = 0;
            int days = 0;
            while (yield >= 100)
            {
                days++;
                yieldSum += yield;
                if (yieldSum >= 26)
                {
                    yieldSum -= 26;
                }
                
                
                yield -= 10;
            }
            if (yieldSum >= 26)
            {
                yieldSum -= 26;
            }
            
            Console.WriteLine(days);
            Console.WriteLine(yieldSum);
        }
    }
}
