using System;

namespace Summer_Outfit
{
    class Program
    {
        static void Main()
        {
            double T = double.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string shoes = "";
            string outfit = "";

            if (timeOfDay == "Morning")
            {
                if (T >= 10 && T <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (T >= 18 && T <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (T >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            if (timeOfDay == "Afternoon")
            {
                if (T >= 10 && T <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (T > 18 && T <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (T >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            if (timeOfDay == "Evening")
            {
                if (T >= 10)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {T} degrees, get your {outfit} and {shoes}.");
        }
    }
}