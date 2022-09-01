using System;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var dictionary = new SortedDictionary<double, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                double currentNum = nums[i];

                if (dictionary.ContainsKey(currentNum))
                {
                    dictionary[currentNum]++;
                }
                else
                {
                    dictionary.Add(currentNum, 1);
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
