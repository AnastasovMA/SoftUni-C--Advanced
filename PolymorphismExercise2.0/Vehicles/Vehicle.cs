using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private double fuel;
        public Vehicle(double fuel, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
        }

        public double Fuel
        {
            get => fuel;
            private set
            {
                if (value > TankCapacity)
                {
                    fuel = 0;
                }
                else 
                {
                    fuel = value;
                }
            }
        }
        public virtual double FuelConsumption { get; }
        public double TankCapacity { get; }
        public virtual bool Drive(double distance)
        {
            bool canContinue = Fuel - FuelConsumption * distance >= 0;
            if (!canContinue)
            {
                return false;
            }
            Fuel -= FuelConsumption * distance;
            return true;
        }
        public virtual void Refuel(double fuelAmount)
        {
            if (Fuel + fuelAmount > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
            }
            if (fuelAmount <= 0)
            {
                throw new ArgumentException($"Fuel must be a positive number");
            }
            Fuel += fuelAmount;
        }
    }
}
