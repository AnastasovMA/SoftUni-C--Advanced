using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            string period = Console.ReadLine();

            string outfit = "";
            string shoes = "";
            //Morning, Afternoon, Evening

            switch (period)
            {
                case "Morning":
                    if (t >= 10 && t <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (t > 18 && t <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (t >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (t >= 10 && t <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (t > 18 && t <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (t >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
            }
            Console.WriteLine($"It's {t} degrees, get your {outfit} and {shoes}.");

            //"It's {градуси} degrees, get your {облекло} and {обувки}."
        }
    }
}
