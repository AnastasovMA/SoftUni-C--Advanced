using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double AirconAdditionalFuelConsumption = 1.6;
        public Truck(double fuel, double fuelConsumption, double tankCapacity) 
            : base(fuel, fuelConsumption, tankCapacity)
        {
        }
        public override double FuelConsumption => base.FuelConsumption + AirconAdditionalFuelConsumption;
        public override void Refuel(double fuelAmount)
        {
            if (Fuel + fuelAmount > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }
            base.Refuel(fuelAmount * 0.95);
        }
    }
}
