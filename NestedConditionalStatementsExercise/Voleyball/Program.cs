using System;

namespace Voleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първият ред съдържа думата "leap" (високосна година) или "normal" (невисокосна).
            string yearType = Console.ReadLine();
            //•	Вторият ред съдържа цялото число p – брой празници в годината (които не са събота и неделя).
            double numberOfHolidays = double.Parse(Console.ReadLine()); // 2/3 от празничните дни играе волейбол
            //•	Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.
            double weekendsTravel = double.Parse(Console.ReadLine()); //Само неделя 

            // Играе само Уикендите и празнчините дни - 48 уикенди * 2 + Holidays - подходящи за волейбол
            // Не е на работа 3/4 от уикендите - Играе волейбол
            double sofiaVolley = (48 - weekendsTravel) * 3/4;  // не е на работа и не си пътува до родния град
            double holidayVolley = (numberOfHolidays) * 2/3;
            double volleyPlayed = (sofiaVolley + holidayVolley + weekendsTravel);
            double additional = 0;
            switch (yearType)
            {
                case "leap":
                    additional = (volleyPlayed * 0.15);
                    break;
                case "normal":
                    additional = 0;
                    break;
            }
            double gamesPlayed = Math.Floor(additional + volleyPlayed);

            Console.WriteLine(gamesPlayed);



        }
    }
}
