using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise
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
            
            List<int> result = new List<int>();
            int limit = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < limit; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if (firstList.Count != secondList.Count)
            {
                if (firstList.Count > secondList.Count)
                {
                    result.AddRange(GetRemainingNumbers(firstList, secondList));
                }

                else
                {
                    result.AddRange(GetRemainingNumbers(secondList, firstList));

                }
            }
            Console.WriteLine(string.Join(" ", result));

        }

        private static List<int> GetRemainingNumbers(List<int> longerList, List<int> shorterList)
        {
            if (longerList.Count <= shorterList.Count)
            {
                throw new ArgumentException();
            }

            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                result.Add(longerList[i]);
            }
            return result;
        }
    }
}
