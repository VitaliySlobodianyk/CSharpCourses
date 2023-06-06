using Homeworks.HW_5.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_5
{
    public static class Extensions
    {
        public static void Print(this Person person)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(person.DescribeYourself());
            Console.WriteLine("----------------------------------------------------------");
        }

        public static void Print(this object obj)
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(obj.ToString());
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}
