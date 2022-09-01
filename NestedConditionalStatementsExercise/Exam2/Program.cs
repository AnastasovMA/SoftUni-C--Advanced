using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hExam = int.Parse(Console.ReadLine());
            int mExam = int.Parse(Console.ReadLine());
            int hArrive = int.Parse(Console.ReadLine());
            int mArrive = int.Parse(Console.ReadLine());

            string result = "";
            int examInMinutes = hExam * 60;
            int arriveInMinutes = hArrive * 60;
            int examTotal = examInMinutes + mExam;
            int arriveTotal = arriveInMinutes + mArrive;
            int diff = Math.Abs(examTotal - arriveTotal);
            int diffInH = diff / 60;
            int diffInMin = diff % 60;

            if (examTotal < arriveTotal)
            {
                result = "Late";
            }
            else if (diff <= 30 && diff >= 0)
            {
                result = "On time";
            }
            else if (diff > 30)
            {
                result = "Early";
            }
            Console.WriteLine(result);

            if (examTotal >= arriveTotal)
            {
                if (diff < 60)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else if (diff >= 60)
                {
                    if (diffInMin < 10)
                    {
                        Console.WriteLine($"{diffInH}:0{diffInMin} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffInH}:{diffInMin} hours before the start");
                    }
                }
            }
            else if (examTotal < arriveTotal)
            {
                if (diff < 60)
                {
                    Console.WriteLine($"{diff} minutes after the start");
                }
                else if (diff >= 60)
                {
                    if (diffInMin < 10)
                    {
                        Console.WriteLine($"{diffInH}:0{diffInMin} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{diffInH}:{diffInMin} hours after the start");
                    }
                }
            }
        }
    }
}
