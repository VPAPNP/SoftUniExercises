using System;

namespace T11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal pricePerCapsule = 0;
            int daysInMonth = 0;
            int capsulesNum = 0;
            decimal orderPriceTotal= 0;
            decimal  orderPrice = 0;
            for (int i = 1; i <= n; i++)
            {
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                daysInMonth = int.Parse(Console.ReadLine());
                capsulesNum = int.Parse(Console.ReadLine());
                orderPrice = (((decimal)daysInMonth * (decimal)capsulesNum) * (decimal)pricePerCapsule);
                orderPriceTotal += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                orderPrice = 0;
            }
            Console.WriteLine($"Total: ${orderPriceTotal:f2}");
        }
    }
}
