using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                 .Split()
                 .Select(double.Parse)
                 .ToArray();
            Dictionary<double, int> dictionary = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNum = numbers[i];

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
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }
        }
    }
}
