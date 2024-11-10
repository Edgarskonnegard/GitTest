
using System;
using System.Collections.Generic;

namespace OOP_labb3
{
    public abstract class Geometry
    {
        public abstract string Name { get; set; }
        public abstract double Area();
    }

    public class Circle : Geometry
    {
        public override string Name { get; set; } = "Circle";
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 4;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Geometry
    {
        public override string Name { get; set; } = "Rectangle";
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 4;
            Width = 2;
        }

        public override double Area()
        {
            return Length * Width;
        }
    }

    public class Square : Geometry
    {
        public override string Name { get; set; } = "Square";
        public double Side { get; set; }

        public Square()
        {
            Side = 4;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }

    //In this project we use polymorfism to handle the different shapes
    //in the same way. We declare the object and call the Area method but in every instance
    // the area is calculated in a specific way according to the specific shape
    // but still handled the same. We do the same for the Name property. This is done
    // through overriding the attributes in the abstract parent class.
    class Program
    {
        static void Main(string[] args)
        {
            List<Geometry> areas = new List<Geometry>()
            {
                new Circle(),
                new Rectangle(),
                new Square()
            };
            foreach (var area in areas)
            {
                Console.WriteLine($"The area of the {area.Name} is {area.Area()} cm²");
            }
            Console.ReadKey();
        }
    }
}


