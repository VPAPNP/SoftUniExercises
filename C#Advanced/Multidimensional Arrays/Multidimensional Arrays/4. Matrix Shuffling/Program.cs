using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = strings[col];
                }
            }
            string command;
            while ((command  = Console.ReadLine()) != "END")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandArg[0] == "swap" && commandArg.Length == 5)
                {
                    int rowToSwap = int.Parse(commandArg[1]);
                    int colToSwap = int.Parse(commandArg[2]);
                    int rowSwapWith = int.Parse(commandArg[3]);
                    int colSwapWith = int.Parse(commandArg[4]);
                    if (rowToSwap <= matrix.GetLength(0) -1 && colToSwap <= matrix.GetLength(1) && rowSwapWith <= matrix.GetLength(0) - 1 && colSwapWith <= matrix.GetLength(1))
                    {
                        string first = matrix[rowToSwap,colToSwap];
                        string second = matrix[rowSwapWith,colSwapWith];
                        matrix[rowToSwap,colToSwap] = second;
                        matrix[rowSwapWith,colSwapWith] = first;
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row,col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
