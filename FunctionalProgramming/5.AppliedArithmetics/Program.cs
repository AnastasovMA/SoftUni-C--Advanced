using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int divisibleNumber = int.Parse(Console.ReadLine());
            Predicate<int> function = number => number % divisibleNumber != 0;
            int[] modified = numbers.Where(x => function(x)).ToArray();

            Console.WriteLine(string.Join(" ", modified.Reverse()));
        }
    }
}
