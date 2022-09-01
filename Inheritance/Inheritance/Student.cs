using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Student : Person
    {
        private School school; // constructors can be reused by the child's classes

        public Student() { }
        public Student(string name, School school)
            :base(name)
        {
            this.school = school;
        }
    }
}
