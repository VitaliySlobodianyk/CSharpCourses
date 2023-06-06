using Homeworks.Additional_HW5.PhotoBook;
using Homeworks.Additional_HW5.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Additional_HW5
{
    public static class AdditionalHW5
    {
        public static void Execute()
        {
            PhotoBookTest.Test();


            var square = new Rectangle(5, 3);
            Console.WriteLine(square.ToString());

            var circle = new Circle(7, new Location(5, 3));
            Console.WriteLine(circle.ToString());
        }
    }
}
