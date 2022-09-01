using System;

namespace MessingAround
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            if (A == "square")
            {
                double sideA = double.Parse(Console.ReadLine());
                double Area = sideA * sideA;
                Console.WriteLine("{0:F3}", Area);
            }
            if (A == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double Area = sideA * sideB;
                Console.WriteLine("{0:F3}", Area);
            }
            if (A == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double Area = (Math.PI * radius * radius);
                Console.WriteLine("{0:F3}", Area);
            }
            if (A == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                double Area =(sideA * sideB) / 2;
                Console.WriteLine("{0:F3}", Area);
            }
        }
    }
}
