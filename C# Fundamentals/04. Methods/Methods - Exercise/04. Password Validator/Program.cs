using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLengthValid = IsPasswordLengthValid(password);
            bool isPassAlphanumeric = IsPasswordAlphanumeric(password);
            bool hasTwoDigits = IsPasswordAtLeastTwoDigitsLong(password);
            if(!isLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(!isPassAlphanumeric)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if(isLengthValid && isPassAlphanumeric && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool IsPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }
        static bool IsPasswordAlphanumeric(string password)
        {
            foreach(char ch in password)
            {
                if(!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }
        static bool IsPasswordAtLeastTwoDigitsLong(string password)
        {
            int digitsCount = 0;
            foreach(char ch in password)
            {
                if(Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
            return digitsCount >= 2;
        }
    }
}
