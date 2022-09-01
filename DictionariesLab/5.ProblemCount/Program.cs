using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.ProblemCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //char[] input = Console.ReadLine().Split("").Select(char.Parse).ToArray();
            SortedDictionary<char, int> set = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (set.ContainsKey(ch))
                {
                    set[ch]++;
                }
                else
                {
                    set.Add(ch, 1);
                }
            }
            foreach (var kvp in set)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
