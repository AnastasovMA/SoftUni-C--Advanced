using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Restaurant
{
    public class Dessert : Food
    {
        public Dessert(string name, decimal price, double grams, double calories) 
            : base(name, price, grams)
        {
            Calories = calories;
        }
        public double Calories { get; set; }
    }
}
