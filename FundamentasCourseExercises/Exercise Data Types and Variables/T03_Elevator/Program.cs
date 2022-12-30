using System;

namespace T03__Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numPeople / capacity);
            Console.WriteLine(courses);
        }
    }
}
