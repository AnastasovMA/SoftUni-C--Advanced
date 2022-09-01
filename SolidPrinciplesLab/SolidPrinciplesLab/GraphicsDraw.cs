using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciplesLab
{
    public class GraphicsDraw 
    {
        public void DrawShape(IShape shape)
        {
            Console.WriteLine(shape.Draw());
        }
    }
}
