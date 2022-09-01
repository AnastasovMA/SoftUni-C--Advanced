using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> resultList = new List<int>(firstList.Count + secondList.Count); // добавяме Лист с дължина колкото другите 2

            int limit = Math.Min(firstList.Count, secondList.Count); // Math.Min взима минимума от двата Листа

            for (int i = 0; i < limit; i++) // добавя елементите от листа в нов лист през 1
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count != secondList.Count)
            {
                if (firstList.Count > secondList.Count)
                {
                    resultList.AddRange(GetRemainingNumbers(firstList, secondList)); // AddRange - добавя числа от лист в края на нов в последователен ред

                }
                else
                {
                    resultList.AddRange(GetRemainingNumbers(secondList, firstList));

                }
            }
            Console.WriteLine(string.Join(" ", resultList));
        }

        private static List<int> GetRemainingNumbers(List<int> longerList, List<int> shorterList) 
        {
            if (longerList.Count <= shorterList.Count)
            {
                throw new ArgumentException();
            }

            List<int> remaining = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++) // добавя останалите числа от големия лист в нов
            {
                remaining.Add(longerList[i]); 
            }
            return remaining;
        }
    }
}
