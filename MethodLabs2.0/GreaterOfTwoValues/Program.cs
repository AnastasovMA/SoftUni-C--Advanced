using System;
using System.Linq;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            //GetSumOfOdds(number);
            //GetSumOfEvens(number);
            int result = GetMultipleOfEvenAndOdds(GetSumOfEvens(number), GetSumOfOdds(number));
            Console.WriteLine(result);
        }

        private static int GetSumOfOdds(int number)
        {
            int oddSum = 0;
            for (int i = 0; i < number; i %= 10)
            {
                int currentNum = number % 10;
                number /= 10;

                if (currentNum % 2 != 0)
                {
                    oddSum += currentNum;
                }
            }
            return oddSum;
            Console.WriteLine(oddSum);
        }

        private static int GetSumOfEvens(int number)
        {
            int evensSum = 0;
            for (int i = 0; i < number; i %= 10) // Другият вариант е да се направи с while цикъл 
            {
                int currentNum = number % 10;
                number /= 10;

                if (currentNum % 2 == 0)
                {
                    evensSum += currentNum;
                }
            }
            return evensSum;
            Console.WriteLine(evensSum);
        }

        private static int GetMultipleOfEvenAndOdds(int number, int number2)
        {
            return number * number2;
        }
    }
}
