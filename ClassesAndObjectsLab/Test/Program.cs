using System;

namespace Test
{
    class SystemTest
    {
        static void Main()
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            for (int i = 0; i < 1000000000; i++)
            {
                sum++;
            }
            int endTime = Environment.TickCount;
            Console.WriteLine("The time elapsed is {0}.", (endTime - startTime) / 1000.0); // изчислява милисекундите от включването на компютъра до извикването на метода.
            
            // Environment.TickCount - статично Свойство
            // Console.WriteLine - статичен Метод


        }
    }
}
