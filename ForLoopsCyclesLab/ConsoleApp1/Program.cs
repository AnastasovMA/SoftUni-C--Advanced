using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            for (int i = 0; i < name.Length; i++) // i < ВИНАГИ
            {
                char letter = name[i];
                Console.WriteLine(letter); //Името на стринга + i
            }
        }
    }
}
