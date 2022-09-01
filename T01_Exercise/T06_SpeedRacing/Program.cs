using System;
using System.Collections.Generic;
using System.Linq;

namespace T06_SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new Car[n]; // create an array of Cars to store all the cars
            for (int i = 0; i < n; i++) // we get the info and put the cars in the list
            {
                var input = Console.ReadLine();
                var tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                var model = tokens[0];
                var fuel = decimal.Parse(tokens[1]);
                var fuelConsumption = decimal.Parse(tokens[2]);
                cars[i] = new Car(model, fuel, fuelConsumption);
                // listOfCars.Add(newCar);
            }


            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

                if (input == "End")
                {
                    break;
                }
                var model = tokens[1];
                var amountOfKm = decimal.Parse(tokens[2]);
                cars.Where(p => p.Model == model).ToList().ForEach(c => c.Drive(amountOfKm));

            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:f2} {car.Travelled}");
            }
        }
    }
}
