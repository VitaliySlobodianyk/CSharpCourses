using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5.Shapes
{
    public abstract class Shape
    {
        protected Location c { get; set; }
        public abstract double Area();
        public abstract double Perimeter();
        public new virtual string ToString() {
            return $"""
                Location: ({c.X};{c.Y})
                Area: {Area()}
                Perimeter: {Perimeter()}
                """;
        } 
    }
}
