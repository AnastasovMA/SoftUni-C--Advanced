using System;

namespace _06.ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                result += symbol;
            }

            for (int i = result.Length - 1; i >= 0; i--)
            {
                Console.Write($"{result[i]} ");
            }
        }
    }
}
