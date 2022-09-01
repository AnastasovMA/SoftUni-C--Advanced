using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            GetVowelsCount(str);
        }

        private static void GetVowelsCount(string str)
        {
            str = str.ToLower();
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char currentIndex = str[i];
                if (currentIndex == 'i' ||
                    currentIndex == 'o' ||
                    currentIndex == 'u' ||
                    currentIndex == 'e' ||
                    currentIndex == 'y' ||
                    currentIndex == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
