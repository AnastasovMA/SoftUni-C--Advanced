using System;
using System.Linq;

namespace _05.TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                bool isTopInteger = true;
                int currNum = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    int comparedNum = arr[j];
                    if (currNum <= comparedNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    Console.Write($"{currNum} ");
                }
            }
        }
    }
}
