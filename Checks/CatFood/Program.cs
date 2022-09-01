using System;

namespace CatFood
{
    class Program
    {
        static void Main(string[] args)
        {
            // броят на котките в група и храната им за ден.
            // 1кг = 12.45лв;
            // small cats ( c >= 100 && c < 200);
            // large cats ( c >= 200 && c < 300);
            // huge cats  ( c >= 30  && c < 400);

            int cats = int.Parse(Console.ReadLine());

            int smallCats = 0;
            int largeCats = 0;
            int hugeCats = 0;
            double sum = 0;

            for (int i = 0; i < cats; i++)
            {
                double gramsOfFood = double.Parse(Console.ReadLine());
                sum += gramsOfFood;

                if (gramsOfFood >= 100 && gramsOfFood < 200)
                {
                    smallCats++;
                }
                if (gramsOfFood >= 200 && gramsOfFood < 300)
                {
                    largeCats++;
                }
                if (gramsOfFood >= 300 && gramsOfFood < 400)
                {
                    hugeCats++;
                }
            }
            double foodInKg = sum / 1000;
            double priceOfFood = foodInKg * 12.45;

            Console.WriteLine($"Group 1: {smallCats} cats.");
            Console.WriteLine($"Group 2: {largeCats} cats.");
            Console.WriteLine($"Group 3: {hugeCats} cats.");
            Console.WriteLine($"Price for food per day: {priceOfFood:f2} lv.");
        }
    }
}
