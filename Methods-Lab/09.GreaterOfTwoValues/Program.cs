using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueType = Console.ReadLine();

            switch (valueType)
            {
                case "int":
                    Console.WriteLine(GetMax(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break;
                case "char":
                    Console.WriteLine(GetMax(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine())));
                    break;
                case "string":
                    Console.WriteLine(GetMax((Console.ReadLine()),(Console.ReadLine())));
                    break;
                default:
                    break;
            }
        }

        private static char GetMax(char v1, char v2)
        {
            return (char)Math.Max(v1, v2);
        }
        private static int GetMax(int v1, int v2)
        {
            return Math.Max(v1, v2);
        }
        private static string GetMax(string v1, string v2)
        {
            var compare = v1.CompareTo(v2);

            if (compare < 0)
            {
                return v2;
            }
            else
            {
                return v1;
            }
        }
    }
}
