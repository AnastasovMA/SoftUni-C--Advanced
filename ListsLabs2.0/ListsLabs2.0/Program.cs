using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsLabs2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1]; // добавя стойността на двата индекса
                    numbers.RemoveAt(i + 1); // маха следващият индекс
                    i = -1; // Връща числото на първият индекс
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
