using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Програма, която да напише колко пари са й необходими да си плати сметката. (да се пресмята в лв./кг.

            double priceOfStrawberries = double.Parse(Console.ReadLine());
            double bananasInKg = double.Parse(Console.ReadLine());
            double orangesInKg = double.Parse(Console.ReadLine());
            double rasperriesInKg = double.Parse(Console.ReadLine());
            double strawberriesInKg = double.Parse(Console.ReadLine());

            double priceOfRasperries = 0.5 * priceOfStrawberries;
            double priceOfOranges = 0.6 * priceOfRasperries;
            double priceOfBananas = 0.2 * priceOfRasperries;

            double sum = priceOfStrawberries * strawberriesInKg + priceOfRasperries * rasperriesInKg  + priceOfOranges * orangesInKg + priceOfBananas * bananasInKg;
            Console.WriteLine(sum);


          
        }
    }
}
