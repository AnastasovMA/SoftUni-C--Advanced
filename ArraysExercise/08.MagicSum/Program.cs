using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int secondNum = arr[j];

                    if (currNum + secondNum == magicNumber)
                    {
                        Console.WriteLine($"{currNum} {secondNum}");
                    }
                }
            }
        }
    }
}
