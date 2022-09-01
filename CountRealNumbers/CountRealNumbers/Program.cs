using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            //double[] numbers = Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .Select(double.Parse)
            //    .ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var key in numbers) // минаваш през числата в листата и гледаш техните стойности
            {
                if (count.ContainsKey(key)) // ако това число го има в листата
                {
                    count[key]++; // увеличаваме стойността
                }
                else // ако го няма 
                {
                    // count[key] = 1; това число има стойност едно 
                    count.Add(key, 1);// добавяме числото и му даваме стойност 1
                }
            }

            foreach (var number in count) // за всяко число в библиотеката 
            {
                Console.WriteLine($"{number.Key} -> {number.Value}"); // принтираме числото и неговата стойност

            }

        }
    }
}
