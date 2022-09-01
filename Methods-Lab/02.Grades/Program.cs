using System;

namespace _02.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGrade(double.Parse(Console.ReadLine()));
        }
        static void PrintGrade(double grade)
        {
            string result = "";
            if (grade < 3.00)
            {
                result = "Fail";
            }
            else if (grade < 3.50)
            {
                result = "Poor";
            }
            else if (grade < 4.50)
            {
                result = "Good";
            }
            else if (grade < 5.50)
            {
                result = "Very good";
            }
            else
            {
                result = "Excellent";
            }

            Console.WriteLine(result);
        }
    }
}
