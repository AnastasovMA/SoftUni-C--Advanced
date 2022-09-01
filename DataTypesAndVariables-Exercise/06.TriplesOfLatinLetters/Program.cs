using System;

namespace _06.TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //97, 98, 99
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 97; i < 97 + rotations; i++)
            {
                for (int j = 97; j < 97 + rotations; j++)
                {
                    for (int k = 97; k < 97 + rotations; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
