using System;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Tires[] tires = new Tires[4]
            {
                new Tires(1, 2.5),
                new Tires(1, 2.1),
                new Tires(2, 0.5),
                new Tires(2, 2.3)
            };
            var engine = new Engine(560, 6300);

            Car marioCar = new Car("Mercedes", "S Class", 2020, 200, 20);
            marioCar.Drive(8);
            Console.WriteLine(marioCar.WhoAmI());

            Console.WriteLine();

            Car kaliCar = new Car(); // custom parameters;
            Console.WriteLine(kaliCar.WhoAmI());

            Car kalisNewCar = new Car("BMW", "740d", 2021);
            Console.WriteLine(kalisNewCar.WhoAmI());

            Car mariosNewCar = new Car("SKODA", "Octavia", 2022, 500, 1);
            Console.WriteLine(mariosNewCar.WhoAmI());

            Car fathersCar = new Car("Mercedes", "AMG", 2030, 420, 69, engine, tires);
            Console.WriteLine(fathersCar.WhoAmI());
        }
    }
}
