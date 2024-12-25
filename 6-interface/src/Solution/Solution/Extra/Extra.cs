using System;

namespace Solution.Extra
{
    public interface IShape
    {
        double CalculateArea();
    }

    public abstract class Shape
    {
        public string Name { get; protected set; }

        protected Shape(string name)
        {
            Name = name;
        }
    }

    public class Circle : Shape, IShape
    {
        private double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape, IShape
    {
        private double Width { get; set; }
        private double Height { get; set; }

        public Rectangle(string name, double width, double height) : base(name)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    public class ShapeCalculator
    {
        public static void PrintArea(IShape shape)
        {
            if (shape is Shape namedShape)
            {
                Console.WriteLine($"The area of the {namedShape.Name} is: {shape.CalculateArea():F2}");
            }
            else
            {
                Console.WriteLine($"The area of the shape is: {shape.CalculateArea():F2}");
            }
        }
    }
}