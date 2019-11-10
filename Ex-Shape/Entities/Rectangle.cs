using Ex_Shape.Entities.Enums;

namespace Ex_Shape.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double area()
        {
            return Width * Height;
        }
    }
}
