using System;
using System.Collections.Generic;
using System.Linq;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToArray();

           //var result = words
           //    .Where(x => x.Length % 2 == 0);

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
