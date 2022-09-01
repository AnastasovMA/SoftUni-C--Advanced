using System;

namespace SmallShop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            град /  coffee   water   beer    sweets  peanuts
            //Sofia               0.50    0.80    1.20    1.45    1.60
            //Plovdiv             0.40    0.70    1.15    1.30    1.50
            //Varna               0.45    0.70    1.10    1.35    1.55


            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double priceOfItem = 0;

            switch (city)
            {
                case "Sofia":
                    if (item == "coffee")
                    {
                        priceOfItem = 0.50;
                    }
                    else if (item == "water")
                    {
                        priceOfItem = 0.80;
                    }
                    else if (item == "beer")
                    {
                        priceOfItem = 1.20;
                    }
                    else if (item == "sweets")
                    {
                        priceOfItem = 1.45;
                    }
                    else if (item == "peanuts")
                    {
                        priceOfItem = 1.60;
                    }

                    break;
                case "Plovdiv":
                    if (item == "coffee")
                    {
                        priceOfItem = 0.40;
                    }
                    else if (item == "water")
                    {
                        priceOfItem = 0.70;
                    }
                    else if (item == "beer")
                    {
                        priceOfItem = 1.15;
                    }
                    else if (item == "sweets")
                    {
                        priceOfItem = 1.30;
                    }
                    else if (item == "peanuts")
                    {
                        priceOfItem = 1.50;
                    }

                    break;
                case "Varna":
                    if (item == "coffee")
                    {
                        priceOfItem = 0.45;
                    }
                    else if (item == "water")
                    {
                        priceOfItem = 0.70;
                    }
                    else if (item == "beer")
                    {
                        priceOfItem = 1.10;
                    }
                    else if (item == "sweets")
                    {
                        priceOfItem = 1.35;
                    }
                    else if (item == "peanuts")
                    {
                        priceOfItem = 1.55;
                    }

                    break;
            }
            Console.WriteLine(quantity * priceOfItem);
        }
    }
}
