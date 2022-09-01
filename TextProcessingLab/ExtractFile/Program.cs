using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string file = input[input.Length - 1];

            string[] info = file.Split(".");

            Console.WriteLine($"File name: {info[0]}");
            Console.WriteLine($"File extension: {info[info.Length-1]}");
        }
    }
}
