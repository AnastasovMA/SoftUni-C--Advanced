using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine()
                .Split();

            var dictionary = new Dictionary<string, int>();

            for (int i = 0; i < data.Length; i++)
            {
                string currentChar = data[i].ToLower();

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
                if (kvp.Value % 2 != 0)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
        }
    }
}
