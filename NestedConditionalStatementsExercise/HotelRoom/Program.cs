using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Май/Октомври = Студио -50лв/ нощувка, Апартамент - 65лв
            // Юни/Септември = Студио - 75.20лв, Апартамент - 68.80лв
            // Юли/Август = Студио 76лв, Апартамент -77лв

            string month = Console.ReadLine();
            double stays = double.Parse(Console.ReadLine());

            // •За студио, при повече от 7 нощувки през май и октомври: 5 % намаление. ( stays > 7 - MAY/OCTOBER)
            //•	За студио, при повече от 14 нощувки през май и октомври: 30 % намаление. (stays 14 - MAY/OCTOBER)
            //•	За студио, при повече от 14 нощувки през юни и септември: 20 % намаление. (STAYS > 14 - June/Sep)
            //•	За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.(App stays > 14, 10%)

            double discountS = 0.00;
            double discountAp = 0.00;
            double totalAp = 0;
            double totalStudio = 0;
            switch (month)
            {
                case "May":
                case "October":
                    totalAp = 65 * stays;
                    totalStudio = 50 * stays;
                    if (stays > 7 && stays <= 14)
                    {
                        discountS = totalStudio * 0.05;
                        totalStudio -= discountS; 
                    }
                    else if (stays > 14)
                    {
                        discountS = totalStudio * 0.30;
                        totalStudio -= discountS;
                        discountAp = totalAp * 0.10;
                        totalAp -= discountAp;
                    }
                    break;
                case "June":
                case "September":
                    totalAp = 68.70 * stays;
                    totalStudio = 75.20 * stays;
                    if (stays > 14)
                    {
                        discountS = totalStudio * 0.20;
                        totalStudio -= discountS;
                        discountAp = totalAp * 0.10;
                        totalAp -= discountAp;
                    }
                    
                    break;
                case "July":
                case "August":
                    totalAp = 77 * stays;
                    totalStudio = 76 * stays;
                    if (stays > 14)
                    {
                        discountAp = totalAp * 0.10;
                        totalAp -= discountAp;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {totalAp:F2} lv.");
            Console.WriteLine($"Studio: {totalStudio:F2} lv.");


            // •На първия ред: “Apartment: { цена за целият престой} lv."
            //•	На втория ред: “Studio: { цена за целият престой} lv."


        }
    }
}
