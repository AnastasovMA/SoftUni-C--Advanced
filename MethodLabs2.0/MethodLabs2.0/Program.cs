using System;
using System.Linq;

namespace MethodLabs2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                GetTriangle(i);
            }
            for (int j = number-1; j >= 1; j--)
            {
                GetTriangle(j);
            }
        }

        private static void GetTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                Console.Write(currentNumber + " ");
               // for (int j = currentNumber; j <= number; j++)
               // {
               //     Console.WriteLine(j);
               // }
            }
            Console.WriteLine();
        }
    }
}
