using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int lowerBound = numbers[0];
            int upperBound = numbers[1];
            string conditition = Console.ReadLine();

            Predicate<int> predicate = conditition == "odd"
                ? (number => number % 2 != 0)
                : new Predicate<int>(number => number % 2 == 0);

            List<int> result = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
