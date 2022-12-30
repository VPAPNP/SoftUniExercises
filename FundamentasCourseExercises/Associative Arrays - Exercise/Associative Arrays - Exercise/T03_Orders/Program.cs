using System;
using System.Collections.Generic;
using System.Linq;

namespace T03_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Item> items = new Dictionary<string, Item>();
            string input;
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] inputInfo = input.Split(" ");
                if (!items.ContainsKey(inputInfo[0]))
                {
                    Item item = new Item(double.Parse(inputInfo[1]), double.Parse(inputInfo[2]));
                    items.Add(inputInfo[0], item);
                }
                else
                {
                      Item currentItem = items[inputInfo[0]];
                    currentItem.ChangePriceUpdateQuntity(double.Parse(inputInfo[1]), double.Parse(inputInfo[2]));
                }

            }
            foreach (var kvp in items)
            {


                Console.WriteLine($"{kvp.Key} -> {kvp.Value.GetTotalPrice():F2}");

            }



        }
    }
    public class Item
    {
        public Item(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public double Price { get; set; }
        public double Quantity { get; set; }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }
        public void ChangePriceUpdateQuntity(double newPrice, double newQuantity)
        {
            
            Quantity += newQuantity;
            Price = newPrice;
        }
    }
}
