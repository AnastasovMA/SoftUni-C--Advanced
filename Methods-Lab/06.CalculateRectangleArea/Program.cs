using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(width, length));
        }

        private static double RectangleArea(double size1, double size2)
        {
            return size1 * size2;
        }
    }
}
