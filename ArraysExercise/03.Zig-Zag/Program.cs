using System;
using System.Linq;

namespace _03.Zig_Zag
{
    class Program
    {
        static void Main(string[] args)
        {
            int rotations = int.Parse(Console.ReadLine());
            int[] arr1 = new int[rotations];
            int[] arr2 = new int[rotations];

            for (int i = 0; i < rotations; i++)
            {
                int[] tempArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = tempArr[0];
                    arr2[i] = tempArr[1];
                }
                else
                {
                    arr1[i] = tempArr[1];
                    arr2[i] = tempArr[0];
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
