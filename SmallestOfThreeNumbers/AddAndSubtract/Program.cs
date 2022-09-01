using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());


            int endResult = Subtract(Sum(n1, n2), n3);

            Console.WriteLine(endResult);
        }

        private static int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        private static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

    }
}
