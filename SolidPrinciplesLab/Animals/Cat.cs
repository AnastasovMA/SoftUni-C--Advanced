using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public override string SayHello() // котката трябва да добавя функционалност, а не да променяме.
        {
            return $"{base.SayHello()} Meow";
        }
    }
}
