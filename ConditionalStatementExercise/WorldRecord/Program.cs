using System;

namespace WorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
           
            double slowdownPerMeter = meters / 15;
            double slowdownInSec = (slowdownPerMeter) * 12.5;

            double distance = meters * secondsPerMeter;
            double time = distance + slowdownInSec;

            if (record > time)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {time,0:F2} seconds.");
            }
            if (record < time)
            {
                Console.WriteLine($"No, he failed! He was {time - record,0:F2} seconds slower.");
            }
        }
    }
}
