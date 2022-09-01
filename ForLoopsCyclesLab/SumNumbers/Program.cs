using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numbers; i++)
            {
                int n1 = int.Parse(Console.ReadLine());
                sum += n1;
            }
            Console.WriteLine(sum);
        }
    }
}
