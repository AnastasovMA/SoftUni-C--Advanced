using System;
using System.Collections.Generic;
using System.Text;

namespace T07_RawData
{
    public class Tire
    {

        public Tire(double tirePressure, int tireAge)
        {
            Pressure = tirePressure;
            Age = tireAge;
        }
        public int Age { get; set; }
        public double Pressure { get; set; }
    }
}
