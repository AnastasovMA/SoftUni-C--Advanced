using System;

namespace _08.MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(MathPowResult(number, pow));
        }

        private static double MathPowResult(double num, double pow)
        {
            return Math.Pow(num, pow);
        }
    }
}
