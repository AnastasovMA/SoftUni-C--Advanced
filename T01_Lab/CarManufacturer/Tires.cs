using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tires
    {
        private int year;
        private double pressure;

        public Tires(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
    }
}
