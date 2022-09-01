using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Cat
    {
        private const string TomcatGenre = "Male";

        public Tomcat(string name, int age) 
            : base(name, age, TomcatGenre)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
