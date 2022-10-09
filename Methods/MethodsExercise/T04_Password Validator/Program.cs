using System;

namespace T04_Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPass = Console.ReadLine();
            bool isPassLenghtValid = IsLenghtValid(inputPass);
            bool isPassAlphaNUm = IsPasswordAlphaNumeric(inputPass);
            bool isContainsAtTwo = IsPassContainingAtLeastTwoDig(inputPass);
            if (!isPassLenghtValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isPassAlphaNUm)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isContainsAtTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isContainsAtTwo && isPassAlphaNUm && isPassLenghtValid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsLenghtValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid; 
        }
        static bool IsPasswordAlphaNumeric(string password)
        {
            foreach (char c in password)
            {
                if(!Char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPassContainingAtLeastTwoDig(string password)
        {
            int digitCount = 0;
            
            foreach (var item in password)
            {
                if(Char.IsDigit(item))
                {
                    digitCount++;
                }
                if (digitCount >= 2)
                {
                   return true;
                }
            }
            return false;
        }
    }
}
