using System;

namespace ClassOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Rectangle
    {
        public int Top { get; set; }                 // Classes may hold data (properties)
        public int Left { get; set; }                // Classes may hold data (properties)
        public int Width { get; set; }               // Classes may hold data (properties)
        public int Height { get; set; }              // Classes may hold data (properties)

        int CalcArea()
        {                                            // Classes may hold operations (methods)
            return Width * Height;                     
        }

        public int Bottom // Calculated property
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right // Calculated property
        {
            get
            {
                return Left + Width;
            }
        }
        public bool IsInside(Rectangle r) // Boolean method
        {
            return (r.Left <= Left) && (r.Right >= Right) && (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}
