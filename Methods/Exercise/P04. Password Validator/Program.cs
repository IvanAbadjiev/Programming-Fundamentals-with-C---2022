
namespace P04._Password_Validator
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            ValidatePassword(password);

        }

        static bool ChecksToConteainSixToThenCharecters(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ChecksToAlphanumeric(string password)
        {
            bool isValid = true;
            foreach (char item in password)
            {
                if (char.IsLetterOrDigit(item))
                {

                }
                else
                {
                    isValid = false;
                }

            }
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }







        }

        static bool ChecksToConteaTwoDigit(string password)
        {
            int digitCouter = 0;
            foreach (char item in password)
            {
                if (Char.IsDigit(item))
                {
                    digitCouter++;
                }
            }
            if (digitCouter >= 2)
            {
                return true;
            }
            else
            {
                {
                    return false;
                }
            }
        }

        static void ValidatePassword(string password)
        {
            if (!ChecksToConteainSixToThenCharecters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }


            if (!ChecksToAlphanumeric(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!ChecksToConteaTwoDigit(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (ChecksToConteainSixToThenCharecters(password) && ChecksToAlphanumeric(password) && ChecksToConteaTwoDigit(password))
            {
                Console.WriteLine("Password is valid");
            }

        }
    }
}
