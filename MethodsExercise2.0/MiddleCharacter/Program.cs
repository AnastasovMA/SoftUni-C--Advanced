using System;
using System.Linq;

namespace MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            GetMiddleCharacter(str);
        }

        private static void GetMiddleCharacter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                char wantedCharacter = str[i];
                if (wantedCharacter == str[str.Length/2])
                {
                    if (str.Length % 2 != 0)
                    {
                        Console.WriteLine(wantedCharacter);
                    }
                    else
                    {
                        char prevCharacter =str[i - 1];
                        Console.WriteLine($"{prevCharacter}{wantedCharacter}");
                    }
                }
            }
        }
    }
}
