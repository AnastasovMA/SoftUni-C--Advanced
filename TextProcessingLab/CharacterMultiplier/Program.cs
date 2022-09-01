using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int result = MultiplyWords(words[0], words[1]);

            Console.WriteLine(result);
        }

        private static int MultiplyWords(string first, string second)
        {
            int minLength = Math.Min(first.Length, second.Length); // Вземаме по-малката дължина от двете

            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];
            }

            if (first.Length > second.Length)
            {
                sum += GetRemainingCharacters(first, minLength); // Започваме от индекса, където приключват общите
            }
            else if (second.Length > first.Length)
            {
                sum += GetRemainingCharacters(second, minLength);
            }

            return sum;
        }

        private static int GetRemainingCharacters(string remaining, int idx)
        {
            int result = 0;

            for (int i = idx; i < remaining.Length; i++)
            {
                int current = remaining[i];

                result += current;
            }
            return result;
        }
    }
}
