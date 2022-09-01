using System;

namespace GodzillaVsKingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            // дали предвидените средства са достатъчни
            // брой статисти/облекло за статисти/декор
            // ДЕКОРЪТ е 10% от БЮДЖЕТА
            // при повече от 150 СТАТИСТА има отстъпка на ОБЛЕКЛОТО 10%.

            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double priceOfCloth = double.Parse(Console.ReadLine());

            // ако парите за ДЕКОРА И ДРЕХИТЕ не са достатъчни - o	o	
            //"Not enough money!"
            //"Wingard needs {парите недостигащи за филма} leva more."

            //o	"Action!" 
            //o   "Wingard starts filming with {останалите пари} leva left."

            double clothing = priceOfCloth * people;
            double decoration = budget * 0.10;
            
            if (people > 150)
            {
                clothing=clothing * 0.90;
            }
            double moneySpent = (clothing + (decoration));
            double moneyLeft = Math.Abs(budget - moneySpent);
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
