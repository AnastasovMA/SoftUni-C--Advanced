using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            //Roses , Dahlias, Tulips, Narcissus, Gladiolus

            double roses = 5 * num;
            double dahlias = 3.80 * num;
            double tulips = 2.80 * num;
            double narcissus = 3 * num;
            double gladiolus = 2.5 * num;

            //•	Ако Нели купи повече от 80 Рози - 10 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 90  Далии - 15 % отстъпка от крайната цена
            //•	Ако Нели купи повече от 80 Лалета - 15 % отстъпка от крайната цена
            //•	Ако Нели купи по-малко от 120 Нарциса - цената се оскъпява с 15 %
            //•	Ако Нели Купи по-малко от 80 Гладиоли - цената се оскъпява с 20 %

            double discount = 0;
            double total = 0;
            switch (flower)
            {
                case "Roses":
                    if (num > 80)
                    {
                        discount = roses * 0.10;
                        total = roses - discount;
                    }
                    else
                    {
                        total = roses;
                    }
                    break;
                case "Dahlias":
                    if (num > 90)
                    {
                        discount = 0.15 * dahlias;
                        total = dahlias - discount;
                    }
                    else
                    {
                        total = dahlias;
                    }
                    break;
                case "Tulips":
                    if (num > 80)
                    {
                        discount = 0.15 * tulips;
                        total = tulips - discount;
                    }
                    else
                    {
                        total = tulips;
                    }
                    break;
                case "Narcissus":
                    if (num < 120)
                    {
                        discount = narcissus * 0.15;
                        total = narcissus + discount;
                    }
                    else
                    {
                        total = narcissus;
                    }
                    break;
                case "Gladiolus":
                    if (num < 80)
                    {
                        discount = gladiolus * 0.20;
                        total = gladiolus + discount;
                    }
                    else
                    {
                        total = gladiolus;
                    }
                    break;
            }

            double money = Math.Abs(budget - total);
            if (budget >= total)
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flower} and {money:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {money:F2} leva more.");
            }


            // "Hey, you have a great garden with {броя цвета} {вид цветя} and {останалата сума} leva left."
            // "Not enough money, you need {нужната сума} leva more."
        }
    }
}
