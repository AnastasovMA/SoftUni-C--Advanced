using System;

namespace NestedConditionalStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // "r" реда и "c" колони

            string projectionType = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());


            //            •	Premiere – премиерна прожекция, на цена 12.00 лева.
            //            •	Normal – стандартна прожекция, на цена 7.50 лева.
            //            •	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.

            double price = 0;
            switch (projectionType)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }
            double size = r * c;
            Console.WriteLine($"{price * size:F2} leva");
        }
    }
}
