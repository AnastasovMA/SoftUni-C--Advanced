using System;

namespace SingleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.Meow();
            cat.Eat();

            dog.Bark();
            dog.Eat();
        }
    }
}
