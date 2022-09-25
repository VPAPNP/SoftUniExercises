using System;

namespace T06_Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int resCapacity = 255;
            int resCurFill = 0;
            for (int i = 0; i < n; i++)
            {
                int flow = int.Parse(Console.ReadLine());
                if (flow <= resCapacity)
                {
                    resCapacity -= flow;
                    resCurFill += flow;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            Console.WriteLine(resCurFill);
        }
    }
}
