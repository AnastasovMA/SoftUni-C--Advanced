using System;
using System.Linq;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool passwordIsValid = true;

            if (!ContainsCorrectNumberOfCharacters(input))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                passwordIsValid = false;
            }
            if (ContainsInvalidCharacters(input))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                passwordIsValid = false;
            }
            //ContainsCorrectNumberOfCharacters(input);

            if (!ContainsCorrectNumberOfDigits(input))
            {
                Console.WriteLine("Password must have at least 2 digits");
                passwordIsValid = false;
            }
            if (passwordIsValid)
            {
                Console.WriteLine("Password is valid");
            }
            //ContainsCorrectNumberOfDigits(input);
        }

        private static bool ContainsCorrectNumberOfDigits(string password)
        {
            int requiredCount = 2;
            int count = 0;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol)) // ако character-a е Digit - увеличаваме count-a
                {
                    count++;

                    if (count == requiredCount)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool ContainsInvalidCharacters(string input)
        {
            foreach (var symbol in input) // преглеждаме всеки символ в инпута
            {
                if (!char.IsLetterOrDigit(symbol)) // Ако character-a е различен от LetterOrDigit - спираме кода
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ContainsCorrectNumberOfCharacters(string input)
        {
            return input.Length >= 6 && input.Length <= 10;
        }
    }
}
