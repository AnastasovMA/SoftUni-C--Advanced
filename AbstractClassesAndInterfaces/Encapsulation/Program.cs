using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mario = new Person("Mario", 20, 340);
            Console.WriteLine(mario);
            mario.IncreaseSalary(50);
            Console.WriteLine(mario);
        }
    }
}
