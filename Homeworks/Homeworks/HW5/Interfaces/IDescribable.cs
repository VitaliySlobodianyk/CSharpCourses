using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_5.Interfaces
{
    public interface IDescribable
    {
       string DescribeYourself();
       void Print() {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(DescribeYourself());
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}
