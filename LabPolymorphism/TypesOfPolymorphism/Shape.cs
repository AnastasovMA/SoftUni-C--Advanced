using System;
using System.Collections.Generic;
using System.Text;

namespace TypesOfPolymorphism
{
    public class Rectangle
    {
        private double a;
        private double b;
        public Rectangle(double a)
        {
            this.a = a;
        }
        public Rectangle(double a, double b)
            :this(a)
        {
            this.b = b;
        }

        public virtual double Area()
        {
            return a * b;
        }
    }
}
