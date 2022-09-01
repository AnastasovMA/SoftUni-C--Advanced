using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Dice
    {
        public int Sides { get; set; }          
        public string Type { get; set; }
        public Dice() { }
        public Dice(int sides) // Constructor name - has to be the same as the class
        {
            this.Sides = sides; // Overloading default constructor
        }
    }

    class StartUp
    {
        public static void Main()
        {
            Dice dice1 = new Dice();                             // First constructor
            Dice dice2 = new Dice(7); // number of sides         // Second constructor
            // You can have multiple constructors in the same class
        }
    }
}
