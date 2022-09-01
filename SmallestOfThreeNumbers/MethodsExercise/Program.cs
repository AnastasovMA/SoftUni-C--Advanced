using System;

namespace MethodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int smallestNum = PrintSmallestNum(num1, num2, num3);
            Console.WriteLine(smallestNum);
        }

        private static int PrintSmallestNum(int num1, int num2, int num3)
        {
            int result = Math.Min(Math.Min(num1, num2), num3);
            return result;
        }
    }
}
