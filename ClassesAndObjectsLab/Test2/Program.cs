using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int number = rnd.Next(49) + 1;
                Console.Write($"{number} ");
            }
        }
    }
}
