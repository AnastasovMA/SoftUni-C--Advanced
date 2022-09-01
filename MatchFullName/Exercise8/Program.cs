using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new SortedDictionary<string, List<string>>();
            string company = string.Empty;
            string studentID = string.Empty;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] commands = line.Split(" -> ");

                company = commands[0];
                studentID = commands[1];

                if (dictionary.ContainsKey(company))
                {
                    if (dictionary[company].Contains(studentID))
                    {
                        continue;
                    }

                        dictionary[company].Add(studentID);
                }
                else
                {
                    dictionary.Add(company, new List<string>() { studentID });
                }
            }
            //var sortedDictionary = dictionary
            //    .OrderBy(x => x.Key)
            //    .ToDictionary(x => x.Key, x => x.Value);
            //
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var kvP in kvp.Value)
                {
                    Console.WriteLine($"-- {kvP}");
                }
            }
        }
    }
}
