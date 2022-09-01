using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int smallest = int.MaxValue;
            int biggest = int.MinValue;


            for (int i = 0; i < numbers; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < smallest) 
                    smallest = n;
                if (n > biggest)
                    biggest = n ;
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        } 
    }
}
