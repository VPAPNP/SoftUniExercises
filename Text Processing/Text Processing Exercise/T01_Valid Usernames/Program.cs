using System;
using System.Linq;
using System.Net.Http.Headers;

namespace T01_Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            bool isValidName = false;
            foreach (string s in input)
            {
                if (s.Count() >= 3 && s.Count() <= 16)
                {
                    foreach (char ch in s)
                    {
                        if (!char.IsLetterOrDigit(ch) && ch != '-' && ch != '_' )
                        {
                            isValidName = false;
                            break;
                            
                        }
                        else
                        {
                            isValidName = true;
                        }
                    }
                    if (isValidName)
                    {
                        Console.WriteLine(s);
                    }
                }
                
                

            }
        }
    }
}
