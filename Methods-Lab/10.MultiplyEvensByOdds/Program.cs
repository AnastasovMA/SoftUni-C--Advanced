using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }
        private static double GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
        }
        private static double GetSumOfEvenDigits(int number)
        {
            double sum = 0;
            for (int i = 0; i < number; i %= 10)
            {
                int currNum = number % 10;
                number /= 10;
                if (currNum % 2 == 0)
                {
                    sum += currNum;
                }
            }
            return sum;
        }
        private static double GetSumOfOddDigits(int number)
        {
            double sum = 0;
            for (int i = 0; i < number; i %= 10)
            {
                int currNum = number % 10;
                number /= 10;
                if (currNum % 2 != 0)
                {
                    sum += currNum;
                }
            }

            return sum;
        }
    }
}
