using System;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var user in usernames)
            {
                if (HasValidCharacters(user) && HasValidLength(user))
                {
                    Console.WriteLine(user);
                }
            }
        }

        private static bool HasValidCharacters(string user)
        {
            for (int i = 0; i < user.Length; i++)
            {
                char currentChar = user[i];

                if (!char.IsLetterOrDigit(currentChar)
                    && currentChar != '-'
                    && currentChar != '_')
                {
                    return false;
                }
            }
            return true;
        }

        private static bool HasValidLength(string user)
        {
            return user.Length >= 3 && user.Length <= 16;
        }
    }
}
