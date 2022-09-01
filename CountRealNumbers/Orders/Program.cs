using System;
using System.Collections.Generic;
using System.Linq;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceOfProduct = new Dictionary<string, double>();
            var quantityOfProduct = new Dictionary<string, int>();


            while (true)
            {
                string[] productInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string product = productInfo[0];

                if (product == "buy")
                {
                    break;
                }
                double price = double.Parse(productInfo[1]);
                int quantity = int.Parse(productInfo[2]);

                if (!priceOfProduct.ContainsKey(product))
                {
                    priceOfProduct.Add(product, price);
                    quantityOfProduct.Add(product, quantity);
                }
                else
                {
                    quantityOfProduct[product] += quantity;
                    priceOfProduct[product] = price; 
                }
            }
            foreach (var kvp in priceOfProduct)
            {
                string product = kvp.Key;
                double price = kvp.Value;

                int quantity = quantityOfProduct[product];

                Console.WriteLine($"{product} -> {quantity * price:f2}");
            }
        }
    }
}
