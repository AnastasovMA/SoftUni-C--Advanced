using System;
using System.Collections.Generic;
using System.Linq;

namespace T07_RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                var cargo = new Cargo(int.Parse(input[3]), input[4]);
                var tires = new Tire[]
                {
                    new Tire(double.Parse(input[5]), int.Parse(input[6])),
                    new Tire(double.Parse(input[7]), int.Parse(input[8])),
                    new Tire(double.Parse(input[9]), int.Parse(input[10])),
                    new Tire(double.Parse(input[11]), int.Parse(input[12]))
                };
                var car = new Car(input[0], engine, cargo, tires);
                cars.Add(car);
            }

            string info = Console.ReadLine();
            var filtered = new List<Car>();

            if (info == "fragile")
            {
                filtered = cars.Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(p => p.Pressure < 1)).ToList();
            }
            else if (info == "flamable")
            {
                filtered = cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList();
            }

            foreach (var car in filtered)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
