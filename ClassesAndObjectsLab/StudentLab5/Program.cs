using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsLab4
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Hometown { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ");

                if (parts[0] == "end")
                {
                    break;
                }
                string firstName = parts[0];
                string lastName = parts[1];
                string age = parts[2];
                string homecity = parts[3];

                if (doesStudentExists(students, firstName, lastName))
                {
                    Student student = GetStudent(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = homecity;

                }
                else
                {
                    Student student = new Student();

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = homecity;

                    students.Add(student);
                }
            }

            string hometown = Console.ReadLine();

            List<Student> filtered = students
                .Where(x => x.Hometown == hometown)
                .ToList();

            foreach (var student in filtered)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

        private static Student GetStudent(List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
        }

        private static bool doesStudentExists(List<Student> students, string firstName, string lastName)
        {
            foreach (var student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
