using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double elevatorCapacity = double.Parse(Console.ReadLine());

            double result = Math.Ceiling(numberOfPeople / elevatorCapacity);

            Console.WriteLine(result);
        }
    }
}
