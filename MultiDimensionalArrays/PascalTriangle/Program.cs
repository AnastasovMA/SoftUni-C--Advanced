using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jagged = new long[n][];

            for (int i = 0; i < n; i++)
            {
                long[] row = new long[i + 1]; // the length of the row
                row[0] = 1;     // first and last are always 1
                row[i] = 1;     // first and last are always 1

                for (int j = 1; j < i; j++) // in this way we make sure we get the row after "i" always
                {
                    row[j] = jagged[i - 1][j] + jagged[i - 1][j - 1];
                }

                jagged[i] = row;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(' ', jagged[i]));
            }
        }
    }
}
