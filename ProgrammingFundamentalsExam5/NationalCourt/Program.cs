using System;
using System.Collections.Generic;
using System.Linq;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            const int breakHour = 3;

            int peoplePerHourFirst = int.Parse(Console.ReadLine());
            int peoplePerHourSecond = int.Parse(Console.ReadLine());
            int peoplePerHourThird = int.Parse(Console.ReadLine());
            int clients = int.Parse(Console.ReadLine());

            int totalPeoplePerHour = peoplePerHourFirst + peoplePerHourSecond + peoplePerHourThird; // all the people per hour
            int hoursNeededWithoutBreak = (int)Math.Ceiling(clients * 1.0 / totalPeoplePerHour);

            int breakTime = hoursNeededWithoutBreak / breakHour;
            
            if (hoursNeededWithoutBreak % breakHour == 0 && breakTime > 0)
            {
                breakTime--;
            }


            Console.WriteLine($"Time needed: {hoursNeededWithoutBreak + breakTime}h.");
        }
    }
}
