using System;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] train = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                train[i] = passengers;
                sum += passengers;
            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
