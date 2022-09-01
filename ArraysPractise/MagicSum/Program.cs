using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                int sum = 0;

                for (int j = i + 1; j < array.Length; j++)
                {
                    int rightNumber = array[j];
                    sum = currentNumber + rightNumber;

                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"{currentNumber} {rightNumber}");
                    }
                }
            }
        }
    }
}
