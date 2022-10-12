using System;

namespace T08_Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            double result = FacturialDevision(first, second);
            Console.WriteLine($"{result:f2}");
        }
        static double FacturialDevision(double first, double second)
        {
            int facturialFirst = 1;
            int facturialSecond = 1;
            double fac1 = facturialFirst;
            double fac2 = facturialSecond;

            for (int i = 1; i <= first; i++)
            {

                fac1 = fac1 * i;
            }
            for (int j = 1; j <= second; j++)
            {
                fac2 = fac2 * j;

            }
            double result = 0;
            
            result =  fac1 /  fac2;

            return result ;

        }
    }
    
}
