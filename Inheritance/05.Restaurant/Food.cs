using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Restaurant
{
    public class Food : Product
    {
        public Food(string name, decimal price, double grams) 
            : base(name, price)
        {
            Grams = grams;
        }
        public double Grams { get; set; }
    }
}
