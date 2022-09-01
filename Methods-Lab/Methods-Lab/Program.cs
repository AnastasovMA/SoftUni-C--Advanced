using System;

namespace Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
