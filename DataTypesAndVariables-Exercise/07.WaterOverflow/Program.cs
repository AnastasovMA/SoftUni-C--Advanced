using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int tankCapacity = 255;
            int rotations = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < rotations; i++)
            {
                int addedLiters = int.Parse(Console.ReadLine());

                if (sum + addedLiters > tankCapacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                sum += addedLiters;
            }

            Console.WriteLine(sum);
        }
    }
}
