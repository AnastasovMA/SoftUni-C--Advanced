using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AddVat
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<double, double> getVat = number => number * 1.20;
            Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(number => getVat(double.Parse(number)))
                .ToList()
                .ForEach(x => Console.WriteLine($"{x:f2}"));
            //double[] input = Console.ReadLine()
            //    .Split(",", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(number => getVat(double.Parse(number)))
            //    .ToArray();
            //
            //foreach (var number in input)
            //{
            //    Console.WriteLine($"{number:F2}");
            //}
        }
    }
}
