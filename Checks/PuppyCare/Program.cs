using System;

namespace PuppyCare
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFoodKg = int.Parse(Console.ReadLine());
            int foodInGrams = dogFoodKg * 1000;
            bool isAdopted = false;
            int sum = 0;
            int gramsEaten = 0;



            while (!isAdopted)
            {
                string input = Console.ReadLine();


                if (input == "Adopted")
                {
                    isAdopted = true;
                    break;
                }
                gramsEaten += int.Parse(input);
                sum = gramsEaten;
            }

            if (sum > foodInGrams)
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(foodInGrams - sum)} grams more.");
            }
            else if (isAdopted)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - sum} grams.");
            }

        }
    }
}
