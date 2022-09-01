using System;
using System.Numerics;

namespace _02.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum = 1;

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }

            Console.WriteLine(sum);
        }
    }
}
