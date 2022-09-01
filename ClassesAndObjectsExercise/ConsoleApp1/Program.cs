using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < numberStudents; i++)
            {
                string[] studentData = Console.ReadLine()
                    .Split(" ");

                string firstName = studentData[0];
                string lastName = studentData[1];
                double grade = double.Parse(studentData[2]);

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Grade = grade;

                students.Add(student);
            }
            List<Student> filteredStudents = students
                .OrderByDescending(x => x.Grade)
                .ToList();

            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
