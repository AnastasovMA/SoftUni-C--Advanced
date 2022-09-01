using System;
using System.Collections.Generic;
using System.Linq;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<char, int>();

            string word = Console.ReadLine();

            foreach (char letter in word)
            {
                if (letter == ' ')
                {
                    continue;
                }
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter]++;
                }
                else
                {
                    dictionary.Add(letter, 1);
                }
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
