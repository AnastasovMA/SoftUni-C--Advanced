using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue7_InternetAnswer
{
    class VehicleCatalogue
    {
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public int HorsePower { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<VehicleCatalogue> vehicleCatalogue = new List<VehicleCatalogue>();
            int count = 0;

            while (true)
            {
                string[] data = Console.ReadLine()
                    .Split("/");

                if (data[0] == "end")
                {
                    break;
                }

                string type = data[0];
                string brand = data[1];
                string model = data[2];
                int weight = int.Parse(data[3]);
                int horsePower = int.Parse(data[3]);

                VehicleCatalogue vehicle = new VehicleCatalogue();

                vehicle.Type = type;
                vehicle.Brand = brand;
                vehicle.Model = model;
                vehicle.Weight = weight;
                vehicle.HorsePower = horsePower;

                vehicleCatalogue.Add(vehicle);
            }

            List<VehicleCatalogue> filteredCatalogue = vehicleCatalogue
                .OrderBy(vehicle => vehicle.Brand)
                .ToList();

            foreach (var vehicle in filteredCatalogue)
            {
                if (count == 0)
                {
                    Console.WriteLine("Cars: ");
                    count++;
                }

                if (vehicle.Type == "Car")
                {
                    Console.WriteLine($"{vehicle.Brand}: {vehicle.Model} - {vehicle.HorsePower}hp");
                }
            }

            foreach (var vehicle in filteredCatalogue)
            {
                if (count == 1)
                {
                    Console.WriteLine("Trucks: ");
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
