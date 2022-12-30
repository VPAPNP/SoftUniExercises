using System;

namespace T_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numPlaces = int.Parse(Console.ReadLine());
            decimal totalProfit = 0;
            
            for (int i = 1; i <= numPlaces; i++)
            {
                string nameCity = Console.ReadLine();
                decimal income = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());
                
                if (i %3 == 0 && i %5 != 0)
                {
                    income -= expenses * 0.5m;
                }
                if (i %5 == 0)
                {
                    income -= income * 0.1m;
                }
                decimal profit = income - expenses;
                totalProfit += profit;
                Console.WriteLine($"In {nameCity} Burger Bus earned {profit:f2} leva.");

            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
