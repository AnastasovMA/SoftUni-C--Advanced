using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int totalYieldExtracted = 0;
            int workersConsumption = 26;


            while (startingYield >= 100)
            {
                totalYieldExtracted += startingYield;
                totalYieldExtracted -= workersConsumption;

                startingYield -= 10;
                if (startingYield < 100)
                {
                    totalYieldExtracted -= workersConsumption;
                    days++;

                    break;
                }
                days++;
            }

            Console.WriteLine(days);
            Console.WriteLine(totalYieldExtracted);

        }
    }
}
