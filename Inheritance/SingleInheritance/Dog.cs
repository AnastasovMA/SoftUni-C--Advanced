using System;
using System.Collections.Generic;
using System.Text;

namespace SingleInheritance
{
    public class Dog : Animals
    {
        public void Bark()
        {
            Console.WriteLine("I am barking");
        }
    }
}
