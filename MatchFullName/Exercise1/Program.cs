using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word[i];

                if (currentChar == ' ')
                {
                    continue;
                }

                if (dictionary.ContainsKey(currentChar))
                {
                    dictionary[currentChar]++;
                }
                else
                {
                    dictionary.Add(currentChar, 1);
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
