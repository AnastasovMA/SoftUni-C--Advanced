using System;

namespace T05_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = new DateTime();
            DateTime secondDate = new DateTime();
            for (int i = 0; i < 2; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int year = int.Parse(input[0]);
                int month = int.Parse(input[1]);
                int day = int.Parse(input[2]);
                if (i == 0)
                {
                     firstDate = new DateTime(year, month, day);
                }
                else
                {
                     secondDate = new DateTime(year, month, day);
                }
            }

            string diff = Math.Abs((secondDate - firstDate).TotalDays).ToString();
            Console.WriteLine(diff);
            //
            //TimeSpan diff = secondDate.Subtract(firstDate);
            //string diff2 = (secondDate - firstDate).TotalDays.ToString();
            //Console.WriteLine(diff2);


        }
    }
}
