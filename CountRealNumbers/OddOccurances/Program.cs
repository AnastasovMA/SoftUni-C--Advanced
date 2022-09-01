using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordsToLower = word.ToLower();
                if (dictionary.ContainsKey(wordsToLower))
                {
                    dictionary[wordsToLower]++;
                }
                else
                {
                    dictionary.Add(wordsToLower, 1);
                }
            }

            foreach (var item in dictionary)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }
        }
    }
}
