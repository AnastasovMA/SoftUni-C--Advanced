using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirconAdditionalFuelConsumption = 0.9;
        public Car(double fuel, double fuelConsumption, double tankCapacity) 
            : base(fuel, fuelConsumption, tankCapacity)
        {
        }
        public override double FuelConsumption => base.FuelConsumption + AirconAdditionalFuelConsumption;
    }
}
