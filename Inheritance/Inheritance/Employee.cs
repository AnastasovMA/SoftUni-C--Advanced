using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Employee : Person
    {
        //public Employee(string name)
        //    : base(name)
        //{
        //
        //}
        public void Fire(string reasons)
        {
            Console.WriteLine($"{base.Name} got fired because of {reasons}.");
        }
    }
}
