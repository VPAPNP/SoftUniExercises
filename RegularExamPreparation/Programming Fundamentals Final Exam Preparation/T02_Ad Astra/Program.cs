using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02_Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = "(?<Item>(#|\\|)(?<Name>[A-Za-z0-9 ]{1,})(#|\\|)(?<date>[0-9]{2}\\/[0-9]{2}\\/[0-9]{2})(#|\\|)(?<calories>[0-9]{1,4}|10000)(#|\\|))";
            Regex regex= new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches= regex.Matches(input);
            int sumCal = 0;
            foreach (Match match in matches)
            {
                 sumCal += int.Parse(match.Groups["calories"].Value);
            }
                int days = sumCal / 2000;
            if (days < 0)
            {
                days = 0;
            }
            Console.WriteLine($"You have food to last you for: {days} days!");
            if (days > 0)
            {
                foreach (Match item in matches)
                {
                    Console.WriteLine($"Item: {item.Groups["Name"].Value}, Best before: {item.Groups["date"].Value }, Nutrition: {item.Groups["calories"].Value}");
                }
            }

        }
    }
}
