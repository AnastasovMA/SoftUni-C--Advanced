using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehicleCatalogue
{
    class Program
    {
        class Vehicle
        {
            public string Type { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
            public int HorsePower { get; set; }
        }

        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                string[] tokens = input.Split("/");
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int weight = int.Parse(tokens[3]);
                int horsePower = int.Parse(tokens[3]);

                Vehicle vehicle = new Vehicle();

                vehicle.Type = type;
                vehicle.Brand = brand;
                vehicle.Model = model;
                vehicle.Weight = weight;
                vehicle.HorsePower = horsePower;

                vehicles.Add(vehicle);
            }

            var sortedCatalogue = vehicles.OrderBy(x => x.Brand).ToList();
            foreach (var vehicle in sortedCatalogue)
            {
                if (count == 0)
                {
                    Console.WriteLine("Cars:");
                    count++;
                }

                if (vehicle.Type == "Car")
                {
                    Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
                }
            }

            foreach (var vehicle in sortedCatalogue)
            {
                if (count == 1 && vehicle.Type == "Truck")
                {
                    Console.WriteLine("Trucks:");
                    count++;
                }

                if (vehicle.Type == "Truck")
                {
                    Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.Weight}kg");
                }
            }
        }
    }
}
