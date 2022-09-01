using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int currentIdx = 0;

            while (command != "Love!")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                currentIdx += int.Parse(tokens[1]);

                if (currentIdx >= houses.Length)
                {
                    currentIdx = 0;
                }

                if (houses[currentIdx] == 0)
                {
                    Console.WriteLine($"Place {currentIdx} already had Valentine's day.");
                }
                else
                {
                    houses[currentIdx] -= 2;

                    if (houses[currentIdx] == 0)
                    {
                        Console.WriteLine($"Place {currentIdx} has Valentine's day.");
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {currentIdx}.");

            int housesWithoutVD = houses
                .Where(h => h > 0)
                .Count();

            if (housesWithoutVD > 0)
            {
                Console.WriteLine($"Cupid has failed {housesWithoutVD} places.");
            }
            else
            {
                Console.WriteLine($"Mission was succesful.");
            }
        }
    }
}
