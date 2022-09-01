using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                    names.Clear();
                    input = Console.ReadLine();
                }
                else
                {
                    names.Enqueue(input);

                    input = Console.ReadLine();
                }

            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
