using System;

namespace T09_Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float money = float.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            float priceLightbars = float.Parse(Console.ReadLine());
            float priceRobes = float.Parse(Console.ReadLine());
            float priceBelts = float.Parse(Console.ReadLine());
            float numBelts = 0;
            float numLightbars = (float)Math.Ceiling(studentsNum + (studentsNum * 0.1));
            if (studentsNum > 5)
            {
                numBelts = studentsNum - (studentsNum / 6);
            }
            else
            {
                numBelts = studentsNum;
            }
           
            float numRobes = studentsNum;
            float sumPriceLightbars = numLightbars * priceLightbars;
            float sumPriceRobes = numRobes * priceRobes;
            float sumPriceBelts = numBelts * priceBelts;
            float allExpenses = sumPriceBelts + sumPriceLightbars + sumPriceRobes;

            if (money >= allExpenses)
            {
                Console.WriteLine($"The money is enough - it would cost {allExpenses:f2}lv.");
            }
            else if (money < allExpenses)
            {
                Console.WriteLine($" John will need {Math.Abs(money - allExpenses):f2}lv more.");
            }



        }
    }
}
