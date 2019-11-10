namespace Ex_Shape.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() 
        {
        }

        public Rectangle(double width, double height)
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
