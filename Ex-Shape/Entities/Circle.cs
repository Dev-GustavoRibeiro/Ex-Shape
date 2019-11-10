using System;
using Ex_Shape.Entities.Enums;

namespace Ex_Shape.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
