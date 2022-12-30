using System;
using System.Collections.Generic;

namespace T03_Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');
            string[] nameExtention = input[input.Length - 1].Split('.');
            Console.WriteLine($"File name: {nameExtention[0]}");
            Console.WriteLine($"File extension: {nameExtention[1]}");
        }
    }
}
