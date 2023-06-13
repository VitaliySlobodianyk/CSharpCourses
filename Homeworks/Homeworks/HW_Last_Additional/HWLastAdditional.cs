using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_Last_Additional
{
    public class HWLastAdditional
    {
        public static void Execute()
        {
            var extendedCities = new List<City>() {
                new City("London", 10000000),
                new City("Kyiv", 3000000),
                new City("New York", 16000000)

            };
            extendedCities.Sort();
            MethodsWithLINQ.DisplayList(extendedCities);


            var cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            MethodsWithLINQ.DisplayList(cities);
            var sortedCities = MethodsWithLINQ.SortListOfStringsByNameAndLength(cities);
            MethodsWithLINQ.DisplayList(sortedCities);

            var products = new List<string>() { "Butter", "Honey", "Brade", "Biscuit", "Brade", "Butter" };
            MethodsWithLINQ.DisplayList(products);
            var processedProducts = MethodsWithLINQ.ArrangeDistinctItemsInListOfStrings(products);
            MethodsWithLINQ.DisplayList(processedProducts);

            var strings = new string[] { "Welcome", "to", "https://classroom.google" };
            var filteredStrings = MethodsWithLINQ.FilterArrayOfStringsWithMinimalLength(strings, 5);
            MethodsWithLINQ.DisplayList(filteredStrings.ToList());
        }
    }
}

