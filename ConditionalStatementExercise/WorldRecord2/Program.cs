using System;

namespace WorldRecord2
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentRecordSec = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            double delay = 0.0;

            if (meters >= 15)
            {
                delay = Math.Round(meters / 15) * 12.5;
            }
            double distance = (meters * secondsPerMeter);
            double time = distance + delay;

            if (currentRecordSec > time)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(time):F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(time - currentRecordSec):F2} seconds slower.");
            }
          
        }
    }
}
