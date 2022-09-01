using System;
using System.Collections.Generic;
using System.Text;

namespace TypesOfPolymorphism
{
    public class Square : Rectangle
    {
        private double a;
        public Square(double a)
            : base(a)
        {
            this.a = a;
        }
        public override double Area()
        {
            return a * a;
        }
    }
}
