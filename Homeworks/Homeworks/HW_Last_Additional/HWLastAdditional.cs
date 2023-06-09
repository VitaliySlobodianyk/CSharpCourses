﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.HW_Last_Additional
{
    public class HWLastAdditional
    {
        /// <summary>
        /// Implement IComparable interface
        /// </summary>
        public static void Task1() {
            var extendedCities = new List<City>() {
                new City("London", 10000000),
                new City("Kyiv", 3000000),
                new City("New York", 16000000)

            };
            extendedCities.Sort();
            MethodsWithLINQ.DisplayList(extendedCities);
        }

        /// <summary>
        /// LINQ : Display the list according to the length then by name in ascending order :
        /// </summary>
        public static void Task2()
        {
            var cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            MethodsWithLINQ.DisplayList(cities);
            var sortedCities = MethodsWithLINQ.SortListOfStringsByNameAndLength(cities);
            MethodsWithLINQ.DisplayList(sortedCities);
        }

        /// <summary>
        /// LINQ : Arrange distinct elements in the list in ascending order : 
        /// </summary>
        public static void Task3()
        {
            var products = new List<string>() { "Butter", "Honey", "Brade", "Biscuit", "Brade", "Butter" };
            MethodsWithLINQ.DisplayList(products);
            var processedProducts = MethodsWithLINQ.ArrangeDistinctItemsInListOfStrings(products);
            MethodsWithLINQ.DisplayList(processedProducts);
        }

        /// <summary>
        /// LINQ : Find the strings for a specific minimum length :
        /// </summary>
        public static void Task4()
        {
            var strings = new string[] { "Welcome", "to", "https://classroom.google" };
            MethodsWithLINQ.DisplayList(strings.ToList());
            int lengthLimiter = 5;
            var filteredStrings = MethodsWithLINQ.FilterArrayOfStringsWithMinimalLength(strings, 5);
            Console.WriteLine($"Words that have more than {lengthLimiter} symbols length:");
            MethodsWithLINQ.DisplayList(filteredStrings.ToList());
        }

        public static void Execute()
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}

