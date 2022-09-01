using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine(GetResult(number, multiplier));
        }

        private static string GetResult(string number, int multiplier)
        {
            if (multiplier == 0)
            {
                return "0";
            }

            int remainder = 0;

            StringBuilder sb = new StringBuilder();

            for (int i = number.Length-1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                remainder += digit * multiplier;

                if (remainder > 9)
                {
                    int remainderLastDigit = remainder % 10;
                    remainder /= 10;

                    sb.Append(remainderLastDigit.ToString());
                }
                else
                {
                    sb.Append(remainder.ToString());
                    remainder = 0;
                }
            }
            if (remainder > 0)
            {
                sb.Append(remainder.ToString());
            }
            return string.Concat(sb.ToString().Reverse());
        }
    }
}
