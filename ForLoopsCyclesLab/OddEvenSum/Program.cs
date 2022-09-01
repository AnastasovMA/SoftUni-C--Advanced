using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int numbersE = int.Parse(Console.ReadLine());
                    sumEven += numbersE;
                }
                else if (i % 2 != 0)
                {
                    int numbersOdd = int.Parse(Console.ReadLine());
                    sumOdd += numbersOdd;
                }
            }
            
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumOdd-sumEven)}");
            }
        }
    }
}
