using System;
using System.Linq;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int addResult = Add(num1, num2);

            int finalResult = Subtract(addResult, num3);
            Console.WriteLine(finalResult);
        }

        private static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        private static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
