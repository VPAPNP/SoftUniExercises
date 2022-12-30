using System;

namespace T1_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] day = new string[7];
            day[0] = "Monday";
            day[1] = "Tuesday";
            day[2] = "Wednesday";
            day[3] = "Thursday";
            day[4] = "Friday";
            day[5] = "Saturday";
            day[6] = "Sunday";
            int dayOfWeek = int.Parse(Console.ReadLine());
            if (dayOfWeek > 7 || dayOfWeek < 1)
            {
                Console.WriteLine("Invalid day!");
                return;
            }

            Console.WriteLine(day[dayOfWeek -1 ]);

        }
    }
}
