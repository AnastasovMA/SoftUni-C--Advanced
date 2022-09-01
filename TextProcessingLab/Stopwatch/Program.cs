using System;
using System.Diagnostics;
using System.Text;

namespace Stopwatch123
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            StringBuilder text = new StringBuilder();

            stopwatch.Start();

            for (int i = 0; i < 4000000; i++)
            {
                text.Append(i);
            }

            stopwatch.Stop();

            Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }
    }
}
