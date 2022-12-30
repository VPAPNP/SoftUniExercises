using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace T01_Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
            Regex regex = new Regex(pattern);
            List<string> furnitures = new List<string>();
            double totalSpendMoney = 0;
            string input;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string furniture = match.Groups["furniture"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    furnitures.Add(furniture);
                    totalSpendMoney += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var furn in furnitures)
            {
                Console.WriteLine(furn);
            }
            Console.WriteLine($"Total money spend: {totalSpendMoney:f2}");
        }
    }
}
