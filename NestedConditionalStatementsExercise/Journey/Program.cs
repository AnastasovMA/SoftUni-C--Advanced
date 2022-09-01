using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string country = ""; // България, Балкаи
            string place = "";
            double pay = 0;

            // Budget Определя къде ще почива "България, Балканите, Европа"
            // Лято - къмпинг (без Европа) или хотел
            // Европа - Само хотели

            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        country = "Bulgaria";
                        place = "Camp";
                        pay = 0.30 * budget;
                    }
                    else if (budget >= 100 && budget <= 1000)
                    {
                        country = "Balkans";
                        place = "Camp";
                        pay = 0.40 * budget;
                    }
                    else if (budget > 1000)
                    {
                        country = "Europe";
                        place = "Hotel";
                        pay = 0.90 * budget;
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        country = "Bulgaria";
                        place = "Hotel";
                        pay = 0.70 * budget;
                    }
                    else if (budget >= 100 && budget <= 1000)
                    {
                        country = "Balkans";
                        place = "Hotel";
                        pay = 0.80 * budget;
                    }
                    else if (budget > 1000)
                    {
                        country = "Europe";
                        place = "Hotel";
                        pay = 0.90 * budget;
                    }
                    break;
            }
            double total = pay;
            Console.WriteLine($"Somewhere in {country}");
            Console.WriteLine($"{place} - {total:F2}");

            //•	При 100лв.или по-малко – някъде в България
            //o   Лято – 30 % от бюджета
            //o   Зима – 70 % от бюджета

            //•	При 1000лв.или по малко – някъде на Балканите
            //o   Лято – 40 % от бюджета
            //o   Зима – 80 % от бюджета

            //•	При повече от 1000лв. – някъде из Европа
            //o   При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.

        }
    }
}
