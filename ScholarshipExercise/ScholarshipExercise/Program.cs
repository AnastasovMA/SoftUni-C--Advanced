using System;

namespace ScholarshipExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageScore = double.Parse(Console.ReadLine());
            double minimalIncome = double.Parse(Console.ReadLine());

            double excellentScolarship = Math.Floor(averageScore * 25);
            double socialScholarship = Math.Floor(minimalIncome * 0.35);

            if (averageScore >= 5.5)
            {
                if (excellentScolarship >= socialScholarship || income > minimalIncome)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excellentScolarship} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
                }
            }
            else if (averageScore > 4.5 && income < minimalIncome)
            {
                Console.WriteLine($"You get a Social scholarship {socialScholarship} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
