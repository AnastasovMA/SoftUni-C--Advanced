using System;
using System.Linq;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            double result = Calculate(num1, @operator, num2);
            Console.WriteLine(result);
        }

        private static double Calculate(int n1, string @operator, int n2)
        {
            double result = 0.0;
            switch (@operator)
            {
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
            }
            return result;
        }
    }
}
