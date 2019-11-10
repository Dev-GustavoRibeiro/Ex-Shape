using Ex_Shape.Entities.Enums;

namespace Ex_Shape.Entities
{
    abstract class  Shape
    {
        public Color color { get; set; }

        public Shape(Color color) 
        {
            this.color = color;
        }

        public abstract double area();
    }
}
