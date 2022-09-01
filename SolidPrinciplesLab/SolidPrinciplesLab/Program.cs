using System;

namespace SolidPrinciplesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Rectangle rec = new Rectangle();

            GraphicsDraw editor = new GraphicsDraw();

            editor.DrawShape(circle);
            editor.DrawShape(triangle);
            editor.DrawShape(rec);
        }
    }
}
