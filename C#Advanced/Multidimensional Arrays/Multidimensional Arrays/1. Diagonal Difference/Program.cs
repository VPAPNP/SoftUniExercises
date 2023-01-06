using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = numbers[col];
                }
            }
            int leftRightSum = 0;
            int rightLeftSum = 0;
            for (int i = 0,j = size-1; i < size; i++,j--)
            {
                
                leftRightSum += matrix[i, i];
                rightLeftSum += matrix[j, i];
            }
            Console.WriteLine(Math.Abs(leftRightSum - rightLeftSum));
        }
    }
}
