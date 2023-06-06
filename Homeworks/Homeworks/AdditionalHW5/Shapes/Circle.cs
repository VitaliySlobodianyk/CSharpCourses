using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5.Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; protected set; }
        public Circle(double radius): this(radius, new Location(0,0))
        {
        }

        public Circle(double radius, Location location)
        {
            Radius = radius;
            c = location;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"""
                --------------------------
                Circle with location at ({c.X};{c.Y})
                Radius: {Radius}
                Area: {Area()}
                Perimeter {Perimeter()}
                --------------------------
                """;
        }
    }
}
