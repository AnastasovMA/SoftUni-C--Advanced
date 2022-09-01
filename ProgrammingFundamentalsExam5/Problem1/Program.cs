using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTheTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double pricePerKm = double.Parse(Console.ReadLine());
            double priceFoodPerDay = double.Parse(Console.ReadLine());
            double priceHotelPerRoom = double.Parse(Console.ReadLine());

            // Hotel expenses for the group
            // Food expenses for the group 

            double hotelExpenses = people * priceHotelPerRoom * daysOfTheTrip;
            double foodExpenses = people * priceFoodPerDay * daysOfTheTrip;
            bool enoughMoney = true;

            if (people > 10)
            {
                hotelExpenses *= 0.75;
            }

            double totalCurrentExpenses = hotelExpenses + foodExpenses;

            for (int i = 1; i <= daysOfTheTrip; i++)
            {
                int currentDay = i;

                int kmTravlled = int.Parse(Console.ReadLine());

                totalCurrentExpenses += pricePerKm * kmTravlled;


                if (currentDay % 3 == 0 || currentDay % 5 == 0)
                {
                    double addExpenses = totalCurrentExpenses * 0.40;
                    totalCurrentExpenses += addExpenses;
                }

                if (currentDay % 7 == 0)
                {
                    double reducedAmout = totalCurrentExpenses / people;
                    totalCurrentExpenses -= reducedAmout;
                }

                if (totalCurrentExpenses > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {totalCurrentExpenses - budget:f2}$ more.");
                    enoughMoney = false;
                    break;
                }
            }
            if (enoughMoney)
            {
                Console.WriteLine($"You have reached the destination. You have {budget - totalCurrentExpenses:F2}$ budget left.");
            }
        }
    }
}
