using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        private const double AirconAdditionalFuelConsumption = 1.4;

        public Bus(double fuel, double fuelConsumption, double tankCapacity) 
            : base(fuel, fuelConsumption, tankCapacity)
        {
        }
        public override double FuelConsumption => this.IsEmpty ? base.FuelConsumption : base.FuelConsumption + AirconAdditionalFuelConsumption;
        public bool IsEmpty { get; set; } // false
    }
}
