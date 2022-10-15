using System;
using System.Linq; 

namespace T11_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                .Split(" ");
                string cmdType = cmdArgs[0];
                if (cmdType == "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    arr = ExchangeArray(arr, index);
                }
                else if (cmdType == "max" || cmdType == "min")
                {
                    string evenOrOdd = cmdArgs[1];
                    int indexOfElement;
                    if (cmdType == "max")
                    {
                        indexOfElement = IndexOfMaxEvenOrOddElement(arr, evenOrOdd);
                    }
                    else
                    {
                        indexOfElement = IndexOfMinEvenOrOddElement(arr, evenOrOdd);
                    }
                    if (indexOfElement == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(indexOfElement);

                }
                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string evenOrOdd = cmdArgs[2];
                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    int[] elements;
                    if (cmdType == "first")
                    {
                        elements = FirstEvenOrOddElement(arr,count,evenOrOdd);
                    }
                    else
                    {
                        elements = LastEvenOrOddElement(arr,count,evenOrOdd);
                    }
                    PrintArray(elements);

                }
            }
            PrintArray(arr);
        }
        static int[] ExchangeArray(int[] originalArray, int index)
        {
            int[] modifiedArray = new int[originalArray.Length];
            int modifiedArrayIndex = 0;
            for (int i = index + 1; i < originalArray.Length; i++)
            {
                modifiedArray[modifiedArrayIndex++] = originalArray[i];
            }
            for (int i = 0; i <= index; i++)
            {
                modifiedArray[modifiedArrayIndex++] = originalArray[i];
            }
            return modifiedArray;
        }
        static int IndexOfMaxEvenOrOddElement(int[] arr, string evenOrOdd)
        {
            int maxIndex = -1;
            int currMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOdd == "even" && currMax % 2 == 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
                else if (evenOrOdd == "odd" && currNum % 2 != 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }


            }
            return maxIndex;
        }
        static int IndexOfMinEvenOrOddElement(int[] arr, string evenOrOdd)
        {
            int minIndex = -1;
            int currMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOdd == "even" && currMin % 2 == 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
                else if (evenOrOdd == "odd" && currNum % 2 != 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }



            }
            return minIndex;
        }
        static int[] FirstEvenOrOddElement(int[] arr, int count, string evenOrOdd)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }
                int currNum = arr[i];
                if (evenOrOdd == "even" && currNum % 2 == 0)
                {

                    firstElArr[firstElArrIndex++] = currNum;
                }
                else if (evenOrOdd == "odd" && currNum % 2 != 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
            }
            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
             return firstElArr;
        }
        static int[] LastEvenOrOddElement(int[] arr, int count, string evenOrOdd)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }
                int currNum = arr[i];
                if (evenOrOdd == "even" && currNum % 2 == 0)
                {

                    firstElArr[firstElArrIndex++] = currNum;
                }
                else if (evenOrOdd == "odd" && currNum % 2 != 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
            }
            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            firstElArr = ReverseArray(firstElArr);
            return firstElArr;
        }
        static int[] ResizeArray(int[] originalArr, int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = originalArr[i];
            }
            return modifiedArray;
        }
        static int[] ReverseArray(int[] originalArray)
        {
            int[] reversed = new int[originalArray.Length];
            for (int i = originalArray.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - 1 - i] = originalArray[i];
            }
            return reversed;

        }
        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{String.Join(", ",arr)}]");

        }
    }
}


     

     

