using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Цената за наем на кораба през пролетта е  3000 лв.
            //•	Цената за наем на кораба през лятото и есента е  4200 лв.
            //•	Цената за наем на кораба през зимата е  2600 лв.

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double rent = 0;
            double total = 0;
            double discount = 0;

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    if (fishermen <= 6)
                    {
                        discount = 0.10 * rent;
                        total = rent - discount;
                    }
                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        discount = 0.15 * rent;
                        total = rent - discount;
                    }
                    else if (fishermen > 11)
                    {
                        discount = 0.25 * rent;
                        total = rent - discount;
                    }
                    break;
                case "Winter":
                    rent = 2600; 
                    if (fishermen <= 6)
                    {
                        discount = 0.10 * rent;
                        total = rent - discount;
                    }
                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        discount = 0.15 * rent;
                        total = rent - discount;
                    }
                    else if (fishermen > 11)
                    {
                        discount = 0.25 * rent;
                        total = rent - discount;
                    }
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    if (fishermen <= 6)
                    {
                        discount = 0.10 * rent;
                        total = rent - discount;
                    }
                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        discount = 0.15 * rent;
                        total = rent - discount;
                    }
                    else if (fishermen > 11)
                    {
                        discount = 0.25 * rent;
                        total = rent - discount;
                    }
                    break;
            }
            if (fishermen % 2 == 0 && season != "Autumn")
            {
                total = total * 0.95;
            }

            //•	Ако групата е до 6 човека включително  –  отстъпка от 10 %. (fishermen <= 6)
            //•	Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %. (fishermen > 6 && fishermen <= 11)
            //•	Ако групата е от 12 нагоре  –  отстъпка от 25 %. (fishermen > 11)

            //Ако рибарите са четен брой, 5% отстъпка (освен на есен). - ОТСТЪПКАТА СЕ НАЧИСЛЯВА, когато се приспадне от другото

            double money = Math.Abs(budget - total);

            if (total <= budget)
            {
                Console.WriteLine($"Yes! You have {money:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {money:F2} leva.");
            }

            //"Yes! You have {останалите пари} leva left."
            //"Not enough money! You need {сумата, която не достига} leva."



        }
    }
}
