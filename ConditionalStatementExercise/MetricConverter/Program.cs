using System;
using System.Text;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double numE = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();
            int a = 100;
            int b = 10;
            //m/cm/mm 
           
            if (input == "m" && output == "cm")
            {
                numE = numE * a;
            }
            if (input == "cm" && output == "mm")
            {
                numE = numE * b;
            }
            if (input == "mm" && output == "cm")
            {
                numE = numE / b;
            }
            if (input == "cm" && output == "m")
            {
                numE = numE / a;
            }
            if (input == "mm" && output == "m")
            {
                numE = numE / (a*b);
            }
            if (input == "m" && output == "mm")
            {
                numE = numE * (a*b);
            }
            Console.WriteLine($"{numE:F10}");
        }
    }
}
