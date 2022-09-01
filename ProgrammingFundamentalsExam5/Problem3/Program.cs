using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        public static void Swap(List<string> list, int indexA, int indexB)
        {
            string tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Stop")
                {
                    break;
                }
                string[] parts = line.Split(" ");
                string command = parts[0];
                int idx = 0;
                string word1 = "";
                string word2 = "";

                switch (command)
                {
                    case "Delete":
                        idx = int.Parse(parts[1]);
                        if (idx < input.Count && idx > -1)
                        {
                            input.RemoveAt(idx+1);
                        }
                        break;
                    case "Swap":
                        word1 = parts[1];
                        word2 = parts[2];
                        if (input.Contains(word1) && input.Contains(word2))
                        {
                            Swap(input, input.IndexOf(word1), input.IndexOf(word2));
                        }
                        break;
                    case "Put":
                        word1 = parts[1];
                        idx = int.Parse(parts[2])-1;
                        if (idx < input.Count && idx > -1)
                        {
                            if (idx == input.Count-1)
                            {
                                input.Add(word1);
                                break;
                            }
                            input.Insert(idx, word1);
                        }
                        break;
                    case "Sort":
                        input = input
                            .OrderByDescending(x => x)
                            .ToList();
                        break;
                    case "Replace":
                        word1 = parts[1];
                        word2 = parts[2];
                        if (input.Contains(word2))
                        {
                            input.Insert(input.IndexOf(word2), word1);
                            input.Remove(word2);
                        }
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
