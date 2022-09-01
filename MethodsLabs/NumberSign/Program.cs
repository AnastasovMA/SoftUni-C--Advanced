using System;

namespace NumberSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Method(n);
        }

        static void Method(int number)
        {
            string sign = "";

            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }

            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
