using System;

namespace MethodsLabs
{
    class Program
    {
        static void Main()
        {
            PrintNumbers(5, 10);
        }

        static void PrintNumbers(int start, int finish)
        {
            for (int i = start; i <= finish; i++)
            {
                Console.WriteLine("{0} ", i);
            }
        }
    }
}
