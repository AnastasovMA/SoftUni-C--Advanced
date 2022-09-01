using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxBonus = 0;
            double maxAttendences = 0;
            double numberOfStudents = int.Parse(Console.ReadLine());
            double numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})

            for (int i = 0; i < numberOfStudents; i++)
            {
                int studentAttendences = int.Parse(Console.ReadLine());

                if (maxAttendences < studentAttendences)
                {
                    maxAttendences = studentAttendences;
                }
                double totalBonus = Math.Round((double)(studentAttendences / numberOfLectures) * (5 + additionalBonus));

                if (maxBonus < totalBonus)
                {
                    maxBonus = totalBonus;
                }

            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendences} lectures.");
        }
    }
}
