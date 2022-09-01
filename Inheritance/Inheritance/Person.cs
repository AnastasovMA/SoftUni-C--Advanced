using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Person
    {
        public Person()
        {

        }
        public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void Sleep()
        {
            Console.WriteLine("I am sleeping!");
        }
    }
}
