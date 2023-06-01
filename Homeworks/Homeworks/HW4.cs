using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class HW4
    {
        /// <summary>
        /// Write a C# method to find the largest value from N integer values.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns>Maximal number in sequence</returns>
        public static int MaxOfTree(params int[] parameters)
        {
            if (parameters.Length == 0)
                throw new ArgumentException("No parameters to compare");
            return LargestItemInArray(parameters);
        }

        /// <summary>
        /// Write a C# method to find the lowest value from three integer values.
        /// </summary>
        /// <param name="parameters"></param>
        /// <returns>Minimal Number in sequence</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int MinOfTree(params int[] parameters)
        {
            if (parameters.Length == 0)
                throw new ArgumentException("No parameters to compare");
            return SmallestItemInArray(parameters);
        }

        /// <summary>
        /// Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="numberToCompare"></param>
        /// <returns>Closest number to given number of comparation</returns>
        public static int ClosestTo(int num1, int num2, int numberToCompare)
        {

            if (num2 == num1)
                return 0;
            return Math.Abs(numberToCompare - num1) > Math.Abs(numberToCompare - num2) ? num2 : num1;

        }

        /// <summary>
        /// Write a C# method to compute the sum of all the elements of an array of integers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SumOfArray(int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            return result;
        }


        /// <summary>
        /// Write a C# method to compute the sum of all the elements of an array of integers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SumOfArrayRecursive(int[] array, int index = 0, int sum = 0)
        {
            if (index < array.Length)
            {
                return SumOfArrayRecursive(array, index + 1, sum + array[index]);
            }
            return sum;
        }

        /// <summary>
        /// Write a C# method to get the larger value from array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static int LargestItemInArray(int[] array)
        {
            int max = Int32.MinValue;
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        /// <summary>
        /// Write a C# method to get the smallest value from array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int SmallestItemInArray(int[] array)
        {
            int min = Int32.MaxValue;
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        /// <summary>
        /// Write a C# method to get the larger value from array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public static int LargestItemInArrayRecursive(int[] array, int index = 0, int max = int.MinValue)
        {
            if (index < array.Length)
            {
                if (array[index] > max)
                {
                    max = array[index];
                }
                return LargestItemInArrayRecursive(array, index + 1, max);

            }
            return max;
        }

        public static void Execute()
        {
            Console.WriteLine("Task1");
            Console.WriteLine(MaxOfTree(1, 2, 3));
            Console.WriteLine(MaxOfTree(1, 3, -3));
            Console.WriteLine(MaxOfTree(-1, -11, -3));

            Console.WriteLine("Task2");
            Console.WriteLine(MinOfTree(1, 2, 3));
            Console.WriteLine(MinOfTree(1, 3, -3));
            Console.WriteLine(MinOfTree(-1, -11, -3));

            Console.WriteLine("Task3");
            Console.WriteLine(ClosestTo(22, 21, 20));
            Console.WriteLine(ClosestTo(-22, 21, 20));
            Console.WriteLine(ClosestTo(15, 21, 20));
            Console.WriteLine(ClosestTo(15, 12, 20));
            Console.WriteLine(ClosestTo(10, 10, 20));
            Console.WriteLine(ClosestTo(20, 12, 20));

            int[] arr = { 5, 7, 9, 3, 17 };

            Console.WriteLine("Task4");
            Console.WriteLine(LargestItemInArray(arr));
            Console.WriteLine(LargestItemInArrayRecursive(arr));

            Console.WriteLine("Task5");
            Console.WriteLine(SumOfArray(arr));
            Console.WriteLine(SumOfArrayRecursive(arr));
        }
    }
}
