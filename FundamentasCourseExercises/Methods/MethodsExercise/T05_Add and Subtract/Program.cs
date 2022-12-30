using System;

namespace T05_Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int resultSum = SumTwoInt(first, second);
            int finalRes = SubstarctInt(third, resultSum);
            Console.WriteLine(finalRes);

        }
        static int SumTwoInt(int first , int second)
        {
            int result = first + second;
            return result;
        }
        static int SubstarctInt(int third , int result)
        {
            int finalRes = result - third;
            return finalRes;
        }
    }
}
