using System;

namespace T10_Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyborbPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            float cnHeadset = lostGames / 2;
            float cnMouse = lostGames / 3;
            float cnKeyborb = lostGames / 6;
            float cnDisplay = lostGames / 12;

            float expenses = (cnHeadset * headsetPrice)+(cnMouse * mousePrice) + (cnKeyborb * keyborbPrice) + (cnDisplay * displayPrice);
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
