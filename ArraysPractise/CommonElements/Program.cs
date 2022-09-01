using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var array2 = Console.ReadLine()
                .Split(" ")
                .ToArray();

            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write($"{array1[j]} ");
                    }
                }
            }
        }
    }
}
