using System;

namespace T07_Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double coins = double.Parse(input);
             double sumCoins = 0;

            while (input != "Start")
            {
                coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    
                    
                    
                    sumCoins += coins;
                    input = Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                    input = Console.ReadLine();
                }
                

            }
            while (input != "End")
            {


                input = Console.ReadLine();
                if (input != "Nuts" && input != "Water" && input != "Crisps" && input != "Soda" && input != "Coke" && input != "End")
                {
                    Console.WriteLine("Invalid product");
                }
                else if (input == "Nuts" && sumCoins >= 2.0)
                {
                    sumCoins -= 2.0;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (input == "Water"&& sumCoins >= 0.7)
                {
                    sumCoins -= 0.7;
                    Console.WriteLine($"Purchased water");
                }
                else if (input == "Crisps" && sumCoins >= 1.5)
                {
                    sumCoins -= 1.5;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (input == "Soda" && sumCoins >= 0.8)
                {
                    sumCoins -= 0.8;
                    Console.WriteLine($"Purchased soda");
                   
                }
                else if (input == "Coke" && sumCoins >= 1.0)
                {
                    sumCoins -= 1.0;
                    Console.WriteLine($"Purchased coke");
                }
                else if(input == "Nuts" || input == "Water" || input == "Crisps" || input == "Soda" || input == "Coke" )
                {
                    Console.WriteLine("Sorry, not enough money");
                   
                }
                
            }
            Console.WriteLine($"Change: {sumCoins:f2}");


        }
    }
}
