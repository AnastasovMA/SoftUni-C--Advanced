using System;

namespace TryAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Декорът за филма е на стойност 10% от бюджета. 
            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.

            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceCloth = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double cloth = people * priceCloth;

            if (people > 150)
            {
                cloth = cloth * 0.90;
            }
            
            double moneySpent = decor + cloth;

            if (budget < moneySpent)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneySpent - budget,0:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - moneySpent,0:F2} leva left.");
            }

        }
    }
}
