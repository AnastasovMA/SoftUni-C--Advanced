using System;

namespace Animals
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Whiskas");
            Animal dog = new Dog("Gosho", "Meat");
            Animal animal = new Animal("Stamat", "Purjoli");

            Console.WriteLine(animal.ExplainSelf());
            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());

        }
    }
}
