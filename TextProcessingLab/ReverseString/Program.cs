using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string reversed = new string(line.Reverse().ToArray()); // Когато обръщаме винаги трябва да се прави на масив
                Console.WriteLine($"{line} = {reversed}");
            }
        }
    }
}
