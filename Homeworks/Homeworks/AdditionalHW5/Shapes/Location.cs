using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5.Shapes
{
    public class Location
    {
        public double X { get; private set; }
        public double Y { get; private set; }
        public Location(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
