using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    interface ICar
    {
        public string Model { get; }
        public string Colour { get; }
        public abstract string Start();
        public abstract string Stop();
    }
}
