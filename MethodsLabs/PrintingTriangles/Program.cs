using System;

namespace PrintingTriangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                PrintingTriangles(i);
            }

            for (int i = n - 1; i >= 1; i--)
            {
                PrintingTriangles(i);
            }
        }

        static void PrintingTriangles(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();

        }
    }
}
