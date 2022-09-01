using System;

namespace TradeCommisions
{
    class Program
    {
        static void Main(string[] args)
        
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            double comminisions = 0;

            // 2 цифри след десетичната запетая
            // невалиден град ИЛИ обем на продажбата  = error

            switch (city)
            {
                case "Sofia":
                    if (0 <= sells && sells <= 500)
                    {
                        comminisions = 0.05;
                    }
                    else if (500 < sells && sells <= 1000)
                    {
                        comminisions = 0.07;
                    }
                    else if (1000 < sells && sells <= 10000)
                    {
                        comminisions = 0.08;
                    }
                    else if (sells > 10000)
                    {
                        comminisions = 0.12;
                    }
                    break;
                case "Varna":
                    if (0 <= sells && sells <= 500)
                    {
                        comminisions = 0.045;
                    }
                    else if (500 < sells && sells <= 1000)
                    {
                        comminisions = 0.075;
                    }
                    else if (1000 < sells && sells <= 10000)
                    {
                        comminisions = 0.1;
                    }
                    else if (sells > 10000)
                    {
                        comminisions = 0.13;
                    }
                    break;
                case "Plovdiv":
                    if (0 <= sells && sells <= 500)
                    {
                        comminisions = 0.055;
                    }
                    else if (500 < sells && sells <= 1000)
                    {
                        comminisions = 0.08;
                    }
                    else if (1000 < sells && sells <= 10000)
                    {
                        comminisions = 0.12;
                    }
                    else if (sells > 10000)
                    {
                        comminisions = 0.145;
                    }
                    break;
            }
            double total = comminisions * sells;

            if (!(total > 0))
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{comminisions * sells:F2}");
            }
        }
    }
}
