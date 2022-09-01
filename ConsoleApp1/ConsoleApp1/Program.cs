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

            //480.00
            //4.60
            //450.00
            // СОЦИАЛНА Стипендия (35% от MINIMAL WAGE) -- INCOME по-малък от MINIMAL WAGE и AVERAGESCORE > 4.5 
            // ОТЛИЧНА СТИПЕНДИЯ (AVERAGESCORE * 25) -- >= 5.5

            double excellentScolarship = Math.Floor(averageScore * 25);
            double socialScolarship = Math.Floor(minimalWage * 0.35);
            double diff = excellentScolarship - socialScolarship;
            double scholarshipReceived = 0.0;

            //за да получи scholarship - трябва да има >4.5
            
            if (averageScore >= 5.5 && income < minimalWage)
            {
                if (diff >= 0)
                {
                   scholarshipReceived = excellentScolarship;
                }
                
                {
                   scholarshipReceived += socialScolarship;
                }
            }
            else if (income < minimalWage && averageScore >= 4.5)
            {
                scholarshipReceived = scholarshipReceived + socialScolarship;
            }
            else if (averageScore >= 5.5)
            {
                scholarshipReceived = scholarshipReceived + excellentScolarship;
            }
            
            double b = scholarshipReceived;
            
            if (b == socialScolarship)
            {
                Console.WriteLine($"You get a Social scholarship {b} BGN");
            }
            if (b == excellentScolarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {b} BGN");
            }

            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            // дава информация дали ученик има право да получава стипендия И СТОЙНОСТТА НА СТИПЕНДИЯТА, КОЯТО Е ПО-ВИСОКА ЗА НЕГО (т.е. ако е квалифицран за 2 стипендии, коя е по-висока).


        }
    }
}
