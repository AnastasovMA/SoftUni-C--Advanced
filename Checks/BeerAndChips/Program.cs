using System;

namespace BeerAndChips
{
    class Program
    {
        static void Main(string[] args)
        {
            // beer - 1.20
            // (amount * beers) * 0.45;

            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int amount = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double beer = 1.20;
            double totalBeers = amount * beer;
            double priceChips = totalBeers * 0.45;
            double totalChips = Math.Ceiling(priceChips * chips);
            double totalPrice = (totalChips + totalBeers);


            if (budget >= totalPrice)
            {
                Console.WriteLine($"{name} bought a snack and has {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {totalPrice - budget:f2} more leva!");
            }
        }
    }
}
