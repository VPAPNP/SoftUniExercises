using System;
using System.Linq;
using System.Numerics;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][]jaggedArray =new int[rows][];
            for (int row = 0; row < rows; row++)
            {
                int[] cols = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                jaggedArray[row] = cols;
            }
            for (int row = 0; row < rows -1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length ; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row+1].Length ; col++)
                    {
                        jaggedArray[row+1][col] /= 2;
                    }
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandArg[0] == "Add")
                {
                    int row = int.Parse(commandArg[1]);
                    int col = int.Parse(commandArg[2]);
                    int value = int.Parse(commandArg[3]);
                    if (row >= 0 && row < jaggedArray.Length  && col >= 0 && col < jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] += value;
                    }
                    
                }
                else if (commandArg[0] == "Subtract")
                {
                    int row = int.Parse(commandArg[1]);
                    int col = int.Parse(commandArg[2]);
                    int value = int.Parse(commandArg[3]);
                    if (row >= 0 && row < jaggedArray.Length && col >= 0 && col <jaggedArray[row].Length)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
