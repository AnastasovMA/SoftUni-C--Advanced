using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentTaken = double.Parse(Console.ReadLine());

            int vol = length * width * height;
            double volumeTakenByWater = vol - (vol * percentTaken/100);
            Console.WriteLine(volumeTakenByWater/1000);

        }
    }
}
