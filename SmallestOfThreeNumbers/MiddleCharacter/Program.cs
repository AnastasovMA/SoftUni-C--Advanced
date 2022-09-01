using System;

namespace MiddleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            FindMiddleCharacter(str);
        }

        private static void FindMiddleCharacter(string str)
        {
            for (int i = 1; i <= str.Length; i++)
            {
                int middleLetter = (str.Length / 2);
                if (i == middleLetter)
                {
                    Console.WriteLine($"{str[i]}");
                    return;
                }

                else if (str.Length % 2 == 0)
                {
                    Console.WriteLine($"{str[i]}{str[i+1]}");
                    return;
                }
            }
        }
    }
}
