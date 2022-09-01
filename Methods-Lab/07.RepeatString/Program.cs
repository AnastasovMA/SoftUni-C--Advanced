using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatedString(input, count));
        }

        private static string RepeatedString(string input, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
