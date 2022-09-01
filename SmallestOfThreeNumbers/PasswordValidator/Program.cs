using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isValid = true;

            if (!ContainsCorrectLength(password))
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (ConsistsOfNumbersAndDigits(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isValid = false;
            }

            if (!CorrectNumberOfDigits(password, 2))
            {
                Console.WriteLine($"Password must have at least 2 digits");
                isValid = false;
            }

            if (isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CorrectNumberOfDigits(string password, int count)
        {
            int digitCount = 0;
            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    digitCount++;
                    if (digitCount == count)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool ConsistsOfNumbersAndDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ContainsCorrectLength(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
