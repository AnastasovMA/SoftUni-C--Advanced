using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());
            string biggestKeg = "";
            double biggestVolume = 0;

            for (int i = 0; i < rotations ; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currVolume > biggestVolume)
                {
                    biggestVolume = currVolume;
                    biggestKeg = model;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
