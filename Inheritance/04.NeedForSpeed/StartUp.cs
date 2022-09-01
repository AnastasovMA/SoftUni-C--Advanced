using System;

namespace _04.NeedForSpeed
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle motor = new RaceMotorcycle(100, 200);
            motor.Drive(5);

            Console.WriteLine(motor.Fuel);
        }
    }
}
