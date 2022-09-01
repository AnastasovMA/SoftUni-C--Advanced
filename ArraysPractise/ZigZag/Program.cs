using System;
using System.Linq;

namespace ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            int[] upperArray = new int[n];
            int[] lowerArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] arr1 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    upperArray[i] = arr1[0];
                    lowerArray[i] = arr1[1];
                }
                if (i % 2 != 0)
                {
                    upperArray[i] = arr1[1];
                    lowerArray[i] = arr1[0];
                }
            }
            Console.WriteLine(string.Join(" ", upperArray));
            Console.WriteLine(string.Join(" ", lowerArray));
        }
    }
}
