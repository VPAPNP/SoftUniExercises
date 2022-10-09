using System;

namespace T04_Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
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
    }
}
