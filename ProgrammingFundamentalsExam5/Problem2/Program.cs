using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = Console.ReadLine()
                .Split(" ")
                .ToList();

            int n = int.Parse(Console.ReadLine());
            string argument = "";


            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ");
                string command = parts[0];


                switch (command)
                {
                    case "Include":
                        argument = parts[1];
                        coffees.Add(argument);
                        break;
                    case "Remove":
                        argument = parts[1];
                        int count = int.Parse(parts[2]);
                        if (count > coffees.Count || count <= 0)
                        {
                            continue;
                        }
                        if (argument == "first")
                        {
                            coffees.RemoveRange(0, count);
                        }
                        if (argument == "last")
                        {
                            coffees.RemoveRange(coffees.Count - 1, count);
                        }
                        break;
                    case "Prefer":
                        argument = parts[1];
                        string argument2 = parts[2];

                        int coffIdx1 = int.Parse(argument);
                        int coffIdx2 = int.Parse(argument2);
                        //if (coffIdx1 < coffees.Count && coffIdx2 > coffees.Count)
                        //{
                        //
                        //}
                        int biggerIndex = Math.Max(coffIdx1, coffIdx2);
                        if (biggerIndex < coffees.Count && biggerIndex > 0)
                        {
                            string temp = coffees[coffIdx1];
                            coffees[coffIdx1] = coffees[coffIdx2];
                            coffees[coffIdx2] = temp;
                        }
                        break;
                    case "Reverse":
                        coffees.Reverse();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Coffees:");
            //Console.WriteLine();
            Console.WriteLine(string.Join(" ", coffees));
        }
    }
}
