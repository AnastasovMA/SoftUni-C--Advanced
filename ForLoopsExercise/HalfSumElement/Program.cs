using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int biggest = int.MinValue;

            for (int i = 0; i < num; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n > biggest) biggest = n;
                sum += n;


            }
            int left = Math.Abs(biggest - sum);
            int diff = biggest - left;
            if (sum - biggest == biggest)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {biggest}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(diff)}");
            }






            //Yes
            //"Sum = "  + неговата стойност; 

            //No
            //"Diff = " + разликата между най-големия елемент и сумата на останалите 
        }
    }
}
