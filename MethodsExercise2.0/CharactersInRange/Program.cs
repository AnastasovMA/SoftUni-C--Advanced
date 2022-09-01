using System;
using System.Linq;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            GetCharactersInBetween(c1, c2);
        }

        private static void GetCharactersInBetween(char first, char second)
        {
            char start = first;
            char end = second;

            if (start > end)
            {
                start = second;
                end = first;
            }

            for (char i = start; i < end ; i++)
            {
                if (i != start)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
