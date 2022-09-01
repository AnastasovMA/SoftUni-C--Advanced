using System;

namespace TypesOfPolymorphism
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3.0, 4.0);
            Rectangle square = new Square(4.0);

            Console.WriteLine(rectangle.Area());
            Console.WriteLine(square.Area());
        }
    }
}
