using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 1 1 2 3 3 2 2 2 1
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 1;
            int maxCount = 0;
            string numberOfLongestSequence = "";

            for (int i = 1; i < arr.Length; i++)
            {
                int currNumber = arr[i-1];
                int nextNum = arr[i];
                if (currNumber == nextNum)
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                        numberOfLongestSequence = currNumber.ToString();
                    }
                }
                else
                {
                    count = 1;
                }
            }
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write($"{numberOfLongestSequence} ");
            }

        }
    }
}
