using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Catalogue
    { 
       //public Catalogue(string type, string model, string color, double horsePower)
       //{
       //    Type = type;
       //    Model = model;
       //    Color = color;
       //    HorsePower = horsePower;
       //}
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public override string ToString()
        {
            string vehicleStr = $"Type: {(Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {Model}{Environment.NewLine}" +
                                $"Color: {Color}{Environment.NewLine}" +
                                $"Horsepower: {HorsePower}";
            return vehicleStr;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> catalogue = new List<Catalogue>();

            while (true)
            {
                string[] data = Console.ReadLine()
                    .Split(" ");

                if (data[0] == "End")
                {
                    break;
                }

                string type = data[0];
                string model = data[1];
                string color = data[2];
                double horsePower = double.Parse(data[3]);

                Catalogue vehicle = new Catalogue();

               vehicle.Type = type;
               vehicle.Model = model;
               vehicle.Color = color;
               vehicle.HorsePower = horsePower;

                catalogue.Add(vehicle);
            }

            while (true)
            {
                string modelOfVehicle = Console.ReadLine();

                if (modelOfVehicle == "Close the Catalogue")
                {
                    break;
                }
                Console.WriteLine(catalogue.Find(x => x.Model == modelOfVehicle));


                //foreach (var vehicle in catalogue)
                //{
                //    if (vehicle.Model == modelOfVehicle)
                //    {
                //        Console.WriteLine($"Type: {vehicle.Type}");
                //        Console.WriteLine($"Model: {vehicle.Model}");
                //        Console.WriteLine($"Color: {vehicle.Color}");
                //        Console.WriteLine($"Horsepower: {vehicle.HorsePower}");
                //    }
                //}
            }

            List<Catalogue> onlyCars = catalogue
                .Where(x => x.Type == "car")
                .ToList();
            List<Catalogue> onlyTrucks = catalogue
                .Where(x => x.Type == "truck")
                .ToList();

            double totalCarsHorsePower = 0;
            double totalTruckHorsePower = 0;

            foreach (var cars in onlyCars)
            {
                totalCarsHorsePower += cars.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTruckHorsePower += truck.HorsePower;
            }

            double averageCarsHorsePower = totalCarsHorsePower / onlyCars.Count;
            double averageTruckHorsePower = totalTruckHorsePower / onlyTrucks.Count;

            if (onlyCars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }
            if (onlyTrucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHorsePower:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }
}
