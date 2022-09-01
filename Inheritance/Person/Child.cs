using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {

        }

        public override int Age // we can override the property of the main class
        {
            get
            {
                return base.Age; // we use the age given in the Base Class
            }
            set
            {
                if (value > 15)
                {
                    throw new ArgumentException(); // if age is bigger than 15, the object is not a Child
                }
                base.Age = value; // we get the age given in the Base Class 
            }
        }
    }
}
