using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_Last_Additional
{
    public static class MethodsWithLINQ
    {
        public static void DisplayList<T>(List<T> list)
        {
            Console.WriteLine("-----------------------------");
            list.ForEach(item =>
            {
                Console.WriteLine(item?.ToString());
            });
            Console.WriteLine("-----------------------------");
        }

        public static List<string> SortListOfStringsByNameAndLength(List<string> list)
        {
            return list
                .OrderBy(item => item.Length)
                .ThenBy(item => item)
                .ToList();
        }

        public static List<string> ArrangeDistinctItemsInListOfStrings(List<string> list)
        {
            return list
                .Distinct()
                .OrderBy(item => item)
                .ToList();
        }

        public static string[] FilterArrayOfStringsWithMinimalLength(string[] arr, int minimalLength)
        {
            return arr
                 .Where(item => item.Length >= minimalLength)
                 .ToArray();
        }


    }
}
