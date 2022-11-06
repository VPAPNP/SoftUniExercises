using System;
using System.Linq;

namespace T04_Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ').Where(x=> x.Length %2 == 0).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine,strings));
        }
    }
}
