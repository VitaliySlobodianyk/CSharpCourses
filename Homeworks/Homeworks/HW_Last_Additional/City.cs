using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_Last_Additional
{
    internal class City : IComparable<City>
    {
        public string Name { get; set; }
        public ulong Population { get; set; }
        public string Country { get; set; }


        public City(string name)
        {
            Name = name;
        }
        public City(string name, ulong population) : this(name)
        {
            Population = population;
        }

        public int CompareTo(City? other)
        {
            if (other?.Name.CompareTo(this.Name) > 0 && other.Population > this.Population)
            {
                return 1;
            }
            else if (other?.Name.CompareTo(this.Name) <= 0 && other.Population <= this.Population)
            {
                return -1;
            }
            else { return 0; }
        }

        public override string ToString()
        {
            return $" City: {Name}, Population: {Population}"; 
        }
    }
}
