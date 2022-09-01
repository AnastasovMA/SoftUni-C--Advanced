using System;

namespace TryAgain
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
                    int nE = int.Parse(Console.ReadLine());
                    sumEven += nE;
                }
                if (i % 2 != 0)
                {
                    int nO = int.Parse(Console.ReadLine());
                    sumOdd += nO;
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
                Console.WriteLine($"Diff = {Math.Abs(sumOdd - sumEven)}");
            }

        }
    }
}
