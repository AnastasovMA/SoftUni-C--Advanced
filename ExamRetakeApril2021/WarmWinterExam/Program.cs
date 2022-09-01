using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinterExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hatsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] scarfsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> hats = new Stack<int>(hatsInfo);
            Queue<int> scarfs = new Queue<int>(scarfsInfo);

            int maxSetValue = int.MinValue;

            List<int> sets = new List<int>();

            while (scarfs.Count > 0 && hats.Count > 0)
            {
                int currentHat = hats.Peek();
                int currentScarf = scarfs.Peek();
                int set = 0;

                if (currentHat > currentScarf)
                {
                    set += hats.Pop() + scarfs.Dequeue();
                    if (maxSetValue < set)
                    {
                        maxSetValue = set;
                    }
                    sets.Add(set);
                }
                else if (currentHat < currentScarf)
                {
                    hats.Pop();
                    continue;
                }
                else if (currentHat == currentScarf)
                {
                    scarfs.Dequeue();
                    hats.Pop();
                    currentHat++;
                    hats.Push(currentHat);
                }
            }

            Console.WriteLine($"The most expensive set is: {maxSetValue}");
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
