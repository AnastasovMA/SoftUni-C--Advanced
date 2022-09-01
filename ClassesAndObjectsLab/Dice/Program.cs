using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice diceD6 = new Dice();       // new objects of the class
            Dice diceD4 = new Dice();       // new objects of the class


        }
    }

    class Dice
    {
        public int Sides { get; set; }           // Properties - store states
        public string Type { get; set; }         // Properties - store states
        public int Roll()                       // Methods - describe behaviour, store executable code
        {
            Random rnd = new Random();
            return rnd.Next(1, Sides + 1);
        }
        
    }
}
