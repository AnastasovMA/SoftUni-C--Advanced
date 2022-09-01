using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercise1._0
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => this.length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            double surfaceArea = 2 * length * width + 2 * length * height + 2 * width * height;
            double lateralSurfaceArea = (2 * Height) * (Length + Width);
            double volume = Length * Width * Height;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {surfaceArea:f2}");
            sb.AppendLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
            sb.AppendLine($"Volume - {volume:f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
