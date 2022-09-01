using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> register = new HashSet<string>();

            while (input != "END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string carNumber = tokens[1];

                if (direction == "IN")
                {
                    register.Add(carNumber);
                }
                else
                {
                    register.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (register.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, register));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
