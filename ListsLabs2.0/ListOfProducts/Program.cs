using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < number; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }
            products.Sort();

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
