namespace Ex_Shape.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double area()
        {
            return 3.14 * (Radius * Radius);
        }
    }
}
