using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private int money;
        private IList<Product> bagOfProducts;

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            this.bagOfProducts = new List<Product>();
        }
        public string Name 
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Money 
        {
            get => this.money;
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public void Buy(Product product)
        {
            if (Money >= product.Cost)
            {
                Money -= product.Cost;
                bagOfProducts.Add(product);
                Console.WriteLine($"{Name} bought {product.Name}");
            }
            else
            {
                throw new ArgumentException($"{Name} can't afford {product.Name}");
            }
        }

        public override string ToString()
        {
            return $"{Name} - {(bagOfProducts.Count > 0 ? string.Join(", ", bagOfProducts) : "Nothing bought")}";
        }
    }
}
