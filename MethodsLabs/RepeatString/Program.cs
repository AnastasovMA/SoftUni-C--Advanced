using System;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int repeatCycles = int.Parse(Console.ReadLine());

            RepeatMethod(inputString, repeatCycles);
        }

        static void RepeatMethod(string input, int cycle)
        {
            for (int i = 0; i < cycle; i++)
            {
                Console.Write(input);
            }
        }
    }
}
