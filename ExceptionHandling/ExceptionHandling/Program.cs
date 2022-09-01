using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;

            while (a == 0)
            {
                try
                {
                    a = MyParse(Console.ReadLine());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
        public static int MyParse(string number)
        {
            return int.Parse(number);
        }
    }
}
