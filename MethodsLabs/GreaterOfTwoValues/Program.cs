using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            GetMax(valueType, a, b);
        }

        private static void GetMax(string value, string a, string b)
        {
            if (value == "int")
            {
                int a1 = int.Parse(a);
                int b1 = int.Parse(b);

                int result = Math.Max(a1, b1);
                Console.WriteLine(result);

            }

            if (value == "char")
            {
                char a1 = char.Parse(a);
                char b1 = char.Parse(b);

                if (a1 > b1)
                {
                    Console.WriteLine(a1);
                }
                else
                {
                    Console.WriteLine(b1);
                }

            }

            if (value == "string")
            {
                if (a.CompareTo(b) >= 0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(b);

                }
            }
        }
    }
}
