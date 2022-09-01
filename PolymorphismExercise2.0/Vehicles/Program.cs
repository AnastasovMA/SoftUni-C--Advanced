using System;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] truckInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] busInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            Bus bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string command = tokens[0];
                string vehicle = tokens[1];
                double amount = double.Parse(tokens[2]);

                try
                {
                    if (command == "Drive")
                    {
                        if (vehicle == "Car")
                        {
                            CanDrive(car, amount);
                        }
                        else if (vehicle == "Truck")
                        {
                            CanDrive(truck, amount);

                        }
                        else
                        {
                            bus.IsEmpty = false;
                            CanDrive(bus, amount);
                        }
                    }
                    else if (command == "Refuel")
                    {

                        if (vehicle == "Car")
                        {
                            car.Refuel(amount);
                        }
                        else if (vehicle == "Truck")
                        {
                            truck.Refuel(amount);
                        }
                        else
                        {
                            bus.Refuel(amount);
                        }
                    }
                    else
                    {
                        // drive empty
                        bus.IsEmpty = true;
                        CanDrive(bus, amount);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine($"Car: {car.Fuel:f2}");
            Console.WriteLine($"Truck: {truck.Fuel:f2}");
            Console.WriteLine($"Bus: {bus.Fuel:f2}");
        }
        public static void CanDrive(Vehicle vehicle, double distance) // POLYMERISM
        {
            bool canDrive = vehicle.Drive(distance);
            string vehicleType = vehicle.GetType().Name;

            string result = canDrive
                ? $"{vehicleType} travelled {distance} km"
                : $"{vehicleType} needs refueling";

            Console.WriteLine(result);
        }
    }
}
