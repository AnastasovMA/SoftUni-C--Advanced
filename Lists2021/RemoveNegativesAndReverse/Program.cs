using System;
using System.Collections.Generic;
using System.Linq;


namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            num.RemoveAll(n => n < 0);
            num.Reverse();

            if (num.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", num));
            }


        }
    }
}
