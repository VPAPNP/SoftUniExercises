using System;

namespace T03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (countPeople >= 100 && type == "Business")
            {
                countPeople -= 10;
            }
            if (day == "Sunday")
            {
                if (type == "Students")
                {
                    price = 10.46*countPeople;
                }
                if (type == "Business")
                {
                    price = 16 * countPeople;
                }
                if (type == "Regular")
                {
                    price = 22.50 * countPeople;
                }
            }
            if (day == "Saturday")
            {
                if (type == "Students")
                {
                    price = 9.80 * countPeople;
                }
                if (type == "Business")
                {
                    price = 15.60 * countPeople;
                }
                if (type == "Regular")
                {
                    price = 20 * countPeople;
                }
            }
            if (day == "Friday")
            {
                if (type == "Students")
                {
                    price = 8.45 * countPeople;
                }
                if (type == "Business")
                {
                    price = 10.90 * countPeople;
                }
                if (type == "Regular")
                {
                    price = 15 * countPeople;
                }
            }
            if (countPeople >=30 && type == "Students")
            {
                price = price - (price *= 0.15) ;
            }
            if (countPeople >= 10 && countPeople <= 20 && type == "Regular")
            {
                price = price - (price *= 0.05);
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
