using System;
using System.Collections.Generic;
using System.Linq;

namespace TrainsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int limitPassengers = int.Parse(Console.ReadLine());

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] tokens = command.Split(" ");

                if (tokens.Length == 2)
                {
                    int wagonToAdd = int.Parse(tokens[1]);
                    wagons.Add(wagonToAdd);
                }
                else if (tokens.Length == 1)
                {
                    int passengersToAdd = int.Parse(tokens[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (passengersToAdd + wagons[i] <= limitPassengers)
                        {
                            wagons[i] += passengersToAdd;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
