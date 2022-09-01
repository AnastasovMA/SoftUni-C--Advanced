using System;
using System.Linq;

namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[0]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] arr = ReadArrayFromConsole();

                for (int col = 0; col < sizes[0]; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int sum = 0;

            for (int row = 0; row < sizes[0]; row++)
            {
                for (int col = 0; col < sizes[0]; col++)
                {
                    if (row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine(sum);
        }
        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                .Split(new string[] { ", ", " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
