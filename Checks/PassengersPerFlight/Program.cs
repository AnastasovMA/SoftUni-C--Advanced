using System;

namespace PassengersPerFlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCompanies = int.Parse(Console.ReadLine());
            //int passengers = 0;

            // 
            int sum = 0;
            int flightCounts = 0;


            for (int i = 0; i < numberOfCompanies; i++)
            {
                string companyName = Console.ReadLine();
                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "Finish")
                    {
                        break;
                    }
                    flightCounts++;
                    int passengers = int.Parse(input);
                    sum += passengers;
                    
                }
                Console.WriteLine($"{companyName}: {sum / flightCounts} passengers.");
            }
        }
    }
}
