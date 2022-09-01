using System;
using System.Linq;

namespace _08.CondenseArraysToNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray()

            while (numbers1.Length > 1)
            {
                int[] condensed = new int[numbers1.Length - 1];
                for (int i = 0; i < numbers1.Length - 1; i++)
                {
                    condensed[i] = numbers1[i] + numbers1[i + 1];
                }
                numbers1 = condensed;
            }
            foreach (var num in numbers1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
