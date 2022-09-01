using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, List<string>>();

            List<string> students = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] data = line.Split(" : ");
                string course = data[0];
                string student = data[1];

                if (dictionary.ContainsKey(course))
                {
                    dictionary[course].Add(student);
                }
                else
                {
                    dictionary.Add(course, new List<string>() { student });
                }
            }

            Dictionary<string, List<string>> sortedCourses = dictionary
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
