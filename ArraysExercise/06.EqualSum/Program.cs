using System;
using System.Linq;

namespace _06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 3
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;

            int index = 0;
            bool equalSum = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int currDigit = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += arr[k];
                }

                if (leftSum == rightSum)
                {
                    equalSum = true;
                    index = i;
                    break;
                }
                leftSum = 0;
                rightSum = 0;
            }

            if (equalSum)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
