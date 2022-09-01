using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceOfProduct = new Dictionary<string, double>();
            var quantityOfProduct = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "buy")
                {
                    break;
                }

                string[] commands = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string product = commands[0];
                double price = double.Parse(commands[1]);
                int quantity = int.Parse(commands[2]);

                if (priceOfProduct.ContainsKey(product))
                {
                    priceOfProduct[product] = price;
                    quantityOfProduct[product] += quantity;
                }
                else
                {
                    priceOfProduct.Add(product, price);
                    quantityOfProduct.Add(product, quantity);
                }
            }

            foreach (var kvp in priceOfProduct)
            {
                int quantity = quantityOfProduct[kvp.Key];

                Console.WriteLine($"{kvp.Key} -> {kvp.Value * quantity:f2}");
            }
        }
    }
}
