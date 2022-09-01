using System;
using System.Linq;

namespace Orders2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(GetResultFromPower(number, power));
        }

        private static double GetResultFromPower(double num, int power)
        {
            double result = Math.Pow(num, power);
            return result;
        }
    }
}
