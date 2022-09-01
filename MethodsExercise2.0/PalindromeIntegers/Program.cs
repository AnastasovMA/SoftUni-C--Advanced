using System;
using System.Linq;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                Console.WriteLine(IsPalindrome(line));
            }
        }

        private static bool IsPalindrome(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length-1-i]) // проверяваме дали първият и последният символ са един и същ
                {
                    return false; // Ако числата са различни, не е палиндром
                }
            }
            return true;
        }
    }
}
