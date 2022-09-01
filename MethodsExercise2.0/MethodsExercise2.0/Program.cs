using System;
using System.Linq;

namespace MethodsExercise2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMaxNumber(number1, number2, number3));
        }

        private static int GetMaxNumber(int num1, int num2, int num3)
        {
            int result = Math.Min(Math.Min(num1, num2), num3);
            return result;
        }
    }
}
