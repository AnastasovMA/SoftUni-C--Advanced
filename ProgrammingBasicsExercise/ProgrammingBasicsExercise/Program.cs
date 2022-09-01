using System;

namespace ProgrammingBasicsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // броя на дните в кампания и броя на сладкарите (това прочитаме от конзолата)
            // Отделни редове където ще получим броя на ГОФРЕТИ, ПАЛАЧИНКИ и ТОРТИ, които ще бъдат приготвени от 1 СЛАДКАР за 1 ДЕН
            // 1/8 от крайната сума ще бъде използвана за покриване на разходите по продуктите

            //1.Броят на дните, в които тече кампанията – цяло число в интервала[0 … 365]
            //2.Броят на сладкарите – цяло число в интервала[0 … 1000]
            //3.Броят на тортите – цяло число в интервала[0… 2000]
            //4.Броят на гофретите – цяло число в интервала[0 … 2000]
            //5.Броят на палачинките – цяло число в интервала[0 … 2000]

            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfBakers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pankes = int.Parse(Console.ReadLine());

            //•	Торта - 45 лв.
            //•	Гофрета - 5.80 лв.
            //•	Палачинка – 3.20 лв.

            double priceOfCakes = (45 * cakes) * numberOfBakers;
            double priceOfWaffles = (5.8 * waffles) * numberOfBakers;
            double priceOfPancakes = (3.2 * pankes) * numberOfBakers;
            double revenue = (priceOfCakes + priceOfWaffles + priceOfPancakes) * numberOfDays;
            double sum = revenue * (7 / 8); 
            Console.WriteLine(sum); 


            // да се напише порграма която изчислява сумата в края на кампанията



        }
    }
}
