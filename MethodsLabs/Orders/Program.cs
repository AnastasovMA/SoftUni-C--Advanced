using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double totalPrice = PrintPrice(product, quantity);

            Console.WriteLine($"{totalPrice:f2}");
        }

        private static double PrintPrice(string product, double quantity)
        {
            double price = 0; 
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2;
                    break;
            }
            double totalPrice = price * quantity;

            return totalPrice;
        }
    }
}
