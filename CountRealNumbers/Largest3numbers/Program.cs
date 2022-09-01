using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] filtered = numbers
                .OrderByDescending(n => n)
                .Take(3)
                .ToArray();

            foreach (var number in filtered)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
