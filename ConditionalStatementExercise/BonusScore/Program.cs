using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0; // бонусът трябва да се изчисли отделно

            if (number <= 100)
            {
                bonus = 5;
            }
            if (number > 100 && number <= 1000)
            {
                bonus = number * 0.20;
            }
            if (number > 1000)
            {
                bonus = number * 0.10;
            }
            if (number % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (number % 10 == 5) // "==" тва означава, че е дробно на 5
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
