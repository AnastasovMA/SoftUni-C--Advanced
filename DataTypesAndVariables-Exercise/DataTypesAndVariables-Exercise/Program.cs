using System;

namespace DataTypesAndVariables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int firstOperation = num1 + num2;
            int secondOperation = firstOperation / num3;
            int thirdOperation = secondOperation * num4;

            Console.WriteLine(thirdOperation);
        }
    }
}
