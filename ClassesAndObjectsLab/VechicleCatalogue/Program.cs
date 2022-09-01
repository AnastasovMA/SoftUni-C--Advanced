using System;
using System.Collections.Generic;
using System.Linq;

namespace VechicleCatalogue
{
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class CatalogueVehicle
    {
        public List<Car> Car { get; set; } 
        public List<Truck> Truck { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carCatalogue = new List<Car>(); 
            List<Truck> truckCatalogue = new List<Truck>(); 
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
                string ratio = data[3];

                if (type == "Car")
                {
                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = ratio;

                    carCatalogue.Add(car);
                }
                if (type == "Truck")
                {
                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = ratio;

                    truckCatalogue.Add(truck);
                }
            }
        }
    }
}
