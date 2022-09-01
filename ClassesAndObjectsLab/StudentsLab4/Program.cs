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

                Student student = new Student();

                student.FirstName = parts[0];
                student.LastName = parts[1];
                student.Age = parts[2];
                student.Hometown = parts[3];

                students.Add(student);
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
    }
}
