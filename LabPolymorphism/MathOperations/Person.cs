using System;
using System.Collections.Generic;
using System.Text;

namespace MathOperations
{
    public class Person : Mammal, IAnimal
    {
        public virtual void Say()
        {
            Console.WriteLine("I am a Person!");
        }
        public virtual void Do()
        {
            Console.WriteLine("I am Animal!");
        }
    }
}
