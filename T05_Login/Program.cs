using System;

namespace T05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length -1; i >= 0; i--)
            {
                char crChar = username[i];
                password += crChar;
               
            }
            int sumTries = 0;
            string enteredPass;
            while ((enteredPass = Console.ReadLine()) != password)
            {
                if (sumTries >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                sumTries++;
                Console.WriteLine("Incorrect password. Try again.");
                
                
            }
            if (enteredPass == password)
            {
                Console.WriteLine($"User {username} logged in.");
            }

        }
    }
}
