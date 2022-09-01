using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintResult(grade);
        }

        static void PrintResult(double grade)
        {
            string result = "";

            if (grade >= 2 && grade <= 2.99)
            {
                result = "Fail";
            }
            if (grade >= 3 && grade <= 3.49)
            {
                result = "Poor";
            }
            if (grade >= 3.50 && grade <= 4.49)
            {
                result = "Good";
            }
            if (grade >= 4.50 && grade <= 5.49)
            {
                result = "Very good";
            }
            if (grade >= 5.50 && grade <= 6)
            {
                result = "Excellent";
            }

            Console.WriteLine(result);
        }
    }
}
