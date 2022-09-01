using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            CharacterSequence(a, b);
        }

        private static void CharacterSequence(char a, char b)
        {
            if (a > b)
            {
                a = b;
                b = a;
            }
            for (char i = (char)(a + 1); i < b; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
