using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowelsCount = VowelsCount(input);

            Console.WriteLine(vowelsCount);
        }

        private static int VowelsCount(string input)
        {
            int counter = 0;
            input = input.ToLower();

            foreach (char letter in input)
            {
                if (letter == 'a' ||
                    letter == 'i' ||
                    letter == 'u' ||
                    letter == 'e' ||
                    letter == 'y' ||
                    letter == 'o')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
