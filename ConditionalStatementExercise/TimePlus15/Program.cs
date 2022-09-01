using System;

namespace TimePlus15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int time = minutes + 15;
            //часове (00), минути
            if (time >= 60)
            {
                time = time - 60;
                hours = hours + 1;
            }
            
            if (hours > 23)
            {
                hours = 00;
            }
            Console.WriteLine($"{hours}:{time:D2}");
        }
    }
}
