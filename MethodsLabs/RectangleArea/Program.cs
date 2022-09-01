using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1 = int.Parse(Console.ReadLine());
            int side2 = int.Parse(Console.ReadLine());
            int area = RectangleArea(side1, side2);

            Console.WriteLine(area);
        }

        private static int RectangleArea(int a, int b)
        {
            return a * b;
        }
    }
}
