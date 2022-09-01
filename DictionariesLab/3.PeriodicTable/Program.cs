using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> setOfUniqueElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    string currentElement = elements[j];
                    setOfUniqueElements.Add(currentElement);
                }
            }

            var modifiedSet = setOfUniqueElements.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", modifiedSet));

        }
    }
}
