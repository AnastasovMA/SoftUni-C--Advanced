using System;
using System.Linq;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            double result = GetFactorial(n1);
            double result2 =GetFactorial(n2);
            double finalResult = Divide(result, result2);

            Console.WriteLine($"{finalResult:f2}");

        }

        private static double Divide(double n1, double n2)
        {
            return n1 / n2;
        }

        private static double GetFactorial(double n1)
        {
            double sum = 1;
            for (int i = 1; i <= n1; i++)
            {
                int currentNum = i;
                sum *= currentNum;
            }
            return sum;
        }
    }
}
