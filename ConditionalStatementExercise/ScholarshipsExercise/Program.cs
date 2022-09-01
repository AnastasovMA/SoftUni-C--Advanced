using System;

namespace ScholarshipsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageScore = double.Parse(Console.ReadLine());
            double minimalWage = double.Parse(Console.ReadLine());

            // СОЦИАЛНА Стипендия (35% от MINIMAL WAGE) -- INCOME по-малък от MINIMAL WAGE и AVERAGESCORE > 4.5 
            // ОТЛИЧНА СТИПЕНДИЯ (AVERAGESCORE * 25) -- >= 5.5

            double excellentScolarship = averageScore * 25;
            double socialScolarship = minimalWage * 0.35;

            if (socialScolarship < 4.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            if (income < minimalWage && averageScore >= 4.5)
            {
                Console.WriteLine($"You get a Social Scholarship {Math.Round(socialScolarship)} BGN");
            }
            if (averageScore >= 5.5)
            {
              Console.WriteLine($"You get a scolarship for excellent results {Math.Round(excellentScolarship)} BGN");

            }
            if (averageScore >= 5.5 && income < minimalWage)
            {
              if (socialScolarship == excellentScolarship)
                {
                    Console.WriteLine(Math.Round(excellentScolarship));
                }
            }
            
            // дава информация дали ученик има право да получава стипендия И СТОЙНОСТТА НА СТИПЕНДИЯТА, КОЯТО Е ПО-ВИСОКА ЗА НЕГО (т.е. ако е квалифицран за 2 стипендии, коя е по-висока).


        }
    }
}
