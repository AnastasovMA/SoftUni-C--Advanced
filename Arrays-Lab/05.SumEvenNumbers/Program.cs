using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sum = 0;

            foreach (var item in numbers)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
