using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLength = int.Parse(Console.ReadLine());
            Predicate<string> filter = name => name.Length <= nameLength;
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => filter(x))
                .ToList()
                .ForEach(x => Console.WriteLine(x));

        }
    }
}
