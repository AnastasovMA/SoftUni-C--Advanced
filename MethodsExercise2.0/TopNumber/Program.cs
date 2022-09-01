using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int number)
        {
            return IsDivisibleBy(number, 8) && ContainsOddInteger(number);
        }

        private static bool ContainsOddInteger(int number)
        {
            while (number != 0)
            {
                int currentNum = number % 10;

                if (currentNum % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool IsDivisibleBy(int number, int divider)
        {
            int sum = 0;

            while (number != 0)
            {
                int currentNum = number % 10;
                sum += currentNum;

                number /= 10;
            }
            return sum % divider == 0;
        }
    }
}
