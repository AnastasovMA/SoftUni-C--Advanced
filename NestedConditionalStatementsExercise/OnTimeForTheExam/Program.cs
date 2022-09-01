using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            // ON time - в часа или до 30 минути по-рано
            // Early - ПОВЕЧЕ от 30 мин по-рано
            // Late - след часа на изпита

            // Програма - която казва дали студентът е подранил, закъснял, на време - с колко време 

            double examH = double.Parse(Console.ReadLine());
            double examMin = double.Parse(Console.ReadLine());
            double arriveH = double.Parse(Console.ReadLine());
            double arriveMin = double.Parse(Console.ReadLine());

            string result = "";
            double diff = Math.Abs(examMin - arriveMin);
            double hh = Math.Abs(examH - arriveH);
            if (examH == arriveH ) // 9:45 > 9:05 (EARLY) OR 9:30=9:20 (On time) OR 9:00 = 9:40 (LATE)  9:30
            {
                if (examMin > arriveMin)
                {
                    if (diff > 30)
                    {
                        result = "Early";
                    }
                    else if (diff <= 30)
                    {
                        result = "On Time";
                    }
                }
                else
                {
                    result = "Late";
                }
            }
            else if (examH > arriveH) // 9:05 - 8:55
            {
                if (examMin >= arriveMin)
                {
                    result = "Early";
                }
                else if (examMin < arriveMin) 
                {
                    if (diff > 30)
                    {
                        result = "Early";
                    }
                    else if (diff <= 30)
                    {
                        result = "On Time";
                    }
                }
            }
            else if (examH < arriveH)  // (E)8: - (A)9:30
            {
                result = "Late";
            }

            if (result == "Early" || result == "On Time")
            {
                if (examMin >= arriveMin)
                {
                    if (examH == arriveMin)
                    {
                        Console.WriteLine($"{result}");
                        Console.WriteLine($"{diff} minutes before the start");
                    }
                    else if (examH > arriveH)
                    {
                        Console.WriteLine($"{result}");
                        Console.WriteLine($"{hh}:{diff} hours before the start");
                    }
                }
                else if (examMin < arriveMin)
                {

                }
            }
        }
           
    }
}
