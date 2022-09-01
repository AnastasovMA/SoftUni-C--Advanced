using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int leftN1 = int.Parse(Console.ReadLine());
                leftSum += leftN1;
            }
            for (int i = 0; i < numbers; i++)
            {
                int rightN1 = int.Parse(Console.ReadLine());
                rightSum += rightN1;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {rightSum} ");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(rightSum - leftSum)}");
            }
        }
    }
}
