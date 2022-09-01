using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 4];

            for (int row = 0; row < matrix.GetLength(0); row++) // returns the length of the DIMENSION - dimension 0
            {
                for (int col = 0; col < matrix.GetLength(1); col++) // returns the length of the DIMENSION - dimension 1
                {
                    //matrix[row, col] = row + col; // gives the value at the current coordinates
                    Console.WriteLine("{0}", matrix[row, col]);
                }
            }
        }
    }
}
