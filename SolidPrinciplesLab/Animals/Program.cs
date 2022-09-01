using System;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal cat = new Cat();

            Console.WriteLine(animal.SayHello());
            Console.WriteLine(cat.SayHello());
        }
    }
}
