using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<string, List<double>>();

            string student = string.Empty;
            double grade = 0;


            for (int i = 0; i < n; i++)
            {
                student = Console.ReadLine();
                grade = double.Parse(Console.ReadLine());

                if (dictionary.ContainsKey(student))
                {
                    dictionary[student].Add(grade);
                }
                else
                {
                    dictionary.Add(student, new List<double>() { grade });
                }
            }

            Dictionary<string, List<double>> sortedDictionary = dictionary
                .Where(x => x.Value.Average() >= 4.5)
                .OrderByDescending(x => x.Value.Average())
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedDictionary)
            {

                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");

            }
        }
    }
}
