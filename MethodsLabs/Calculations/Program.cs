using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            switch (command)
            {
                case "add":
                    Add(num1, num2);
                    break;
                case "multiply":
                    Multiply(num1, num2);
                    break;
                case "subtract":
                    Subtract(num1, num2);
                    break;
                case "divide":
                    Divide(num1, num2);
                    break;
            }
        }

        private static void Add(int n1, int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        private static void Multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);

        }

        private static void Subtract(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);

        }

        private static void Divide(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
    }
}
