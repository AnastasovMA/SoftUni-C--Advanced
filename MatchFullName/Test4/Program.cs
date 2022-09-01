using System;
using System.Collections.Generic;
using System.Linq;

namespace Test4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var result = nums
                .OrderByDescending(x => x)
                .Take(3);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
