using System;
using System.Data.SqlTypes;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.

            // при над 50 играчки , 25% отстъпка, --
            // 10% отиват за наем от спечелените пари

            double priceOfHoliday = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            int sumToys = puzzle + doll + bear + minion + truck;

            double priceOfPuzzle = puzzle * 2.6;
            double priceOfDoll = doll * 3;
            double priceOfBear = bear * 4.10;
            double priceOfMinion = minion * 8.2;
            double priceOfTruck = truck * 2;

            double priceOfToys = priceOfBear + priceOfDoll + priceOfMinion + priceOfPuzzle + priceOfTruck;
            if (sumToys >= 50)
            {
                double newP = priceOfToys * 0.75;
                double rent = newP * 0.10;
                double moneyLeft = newP - priceOfHoliday - rent;
                double n = Math.Abs(moneyLeft);
                if (moneyLeft > priceOfHoliday)
                {
                    Console.WriteLine($"Yes! {moneyLeft,0:F2} lv left.");
                }
                if (moneyLeft < priceOfHoliday)
                {
                  Console.WriteLine($"Not enough money! {n,0:F2} lv needed.");
                }
            }
            else 
            {
                double rent = priceOfToys * 0.10;
                double moneyLeft = priceOfToys - priceOfHoliday - rent;
                double n = Math.Abs(moneyLeft);
                if (moneyLeft > priceOfHoliday)
                {
                    Console.WriteLine($"Yes! {moneyLeft,0:F2} lv left.");
                }
                if (moneyLeft < priceOfHoliday)
                {
                   Console.WriteLine($"Not enough money! {n, 0:F2} lv needed.");
                }
                
            }
        }
    }
}
