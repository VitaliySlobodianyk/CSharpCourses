using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5.Shapes
{
    internal class Rectangle : Shape
    {
        public double Side1 { get; protected set; }
        public double Side2 { get; protected set; }

        public Rectangle(int side1, int side2) : this(side1, side2, new Location(0,0))
        {
            
        }

        public Rectangle(int side1, int side2, Location location)
        {
            Side1 = side1;
            Side2 = side2;
            c = location;
        }

        public override double Area()
        {
            return Side1 * Side2;
        }

        public override double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }

        public override string ToString()
        {
            return $"""
                --------------------------
                Rectangle:
                Sides: {Side1} {Side2}
                {base.ToString()}
                --------------------------
                """;
        }
    }
}
