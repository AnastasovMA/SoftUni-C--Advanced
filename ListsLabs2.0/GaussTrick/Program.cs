using System;
using System.Collections.Generic;
using System.Linq;

namespace GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < num.Count / 2; i++)
            {
                num[i] += num[num.Count - 1]; // събира първото и последното число
                num.RemoveAt(num.Count - 1); // маха последното число
            }
            Console.WriteLine(string.Join(" ", num));
        }
    }
}
