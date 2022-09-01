using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FurnitureExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^>>(?<item>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            Regex regex = new Regex(pattern);

            List<string> items = new List<string>();
            double totalPrice = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Purchase")
                {
                    break;
                }

                Match match = regex.Match(line);

                if (!match.Success)
                {
                    continue;
                }

                string name = match.Groups["item"].Value;
                double price = double.Parse(match.Groups["price"].Value);
                int quantity = int.Parse(match.Groups["quantity"].Value);

                items.Add(name);

                totalPrice += price * quantity;

            }

            Console.WriteLine("Bought furniture:");

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
