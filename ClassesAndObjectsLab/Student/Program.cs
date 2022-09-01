using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Student
    {
        public string FirstName { get; set; }       // Properties of the Student
        public string LastName { get; set; }        // Properties of the Student
        public int Age { get; set; }                // Properties of the Student

        // getter - provide access to the field
        // setter - provide field change
    }
}
