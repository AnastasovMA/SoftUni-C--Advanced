using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(num);

            Console.WriteLine(result);
        }
        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int rezult = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            return rezult;
        }
        private static int GetSumOfOddDigits(int num)
        {
            int sumOdds = 0;

            while (num > 0)
            {
                int nextNum = num % 10;
                num /= 10;
                if (nextNum % 2 != 0)
                {
                    sumOdds += nextNum;
                }
            }
            return sumOdds;
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int sumEvens = 0;

            while (num > 0)
            {

                int nextNum = num % 10;
                num /= 10;

                if (nextNum % 2 == 0)
                {
                    sumEvens += nextNum;
                }
            }
            return sumEvens;
        }
    }
}
