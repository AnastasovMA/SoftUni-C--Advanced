using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                array[i] = people;
                sum += people;

            }
            Console.WriteLine(string.Join(" ", array));

            Console.WriteLine(sum);
        }
    }
}
