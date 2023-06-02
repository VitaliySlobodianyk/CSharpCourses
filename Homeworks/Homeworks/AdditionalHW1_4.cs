using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class AdditionalHW1_4
    {


        /// <summary>
        /// Write a program in C# Sharp to display a number in reverse order.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int ReverseNumber(int number) {
        
            if ( number < 10 && number > -10) {
                return number;
            }
            short negative = 1;
            if (number < 0)
                negative = -1;

            var reversedNumberCharArray = Math.Abs(number).ToString().Reverse().ToArray();

            string reversedNuberString="";
            foreach (var numberChar in reversedNumberCharArray)
            {
                reversedNuberString += numberChar;
            }

            return  Int32.Parse(reversedNuberString) * negative;
        }


        /// <summary>
        /// Write a C# Sharp program to display an alphabet pattern like A with an asterisk.Reversed string is:Display the pattern like 'A' with an asterisk
        /// </summary>
        static void DisplayA()
        {
            int rows = 11;

            for (int i = 0; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    //connecting 2 sides of lettel
                    else if (i == rows / 2 + 1 && k > 1 && k < 2 * i - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void BubbleSort(int[] arr, bool asc = true)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (asc && arr[j] < arr[i])
                    {
                        var tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                    else if (!asc && arr[j] > arr[i])
                    {
                        var tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
        /// <summary>
        /// Write a C# Sharp program to find the N largest element in an array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="index"></param>
        /// <returns>N largest element in an array</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int NLargestItemInArray(int[] array, int index = 1)
        {
            if (index > array.Length || index < 1)
            {
                throw new ArgumentException("Given index does not correspond Array Length");
            }

            int[] newArray = new int[array.Length];
            array.CopyTo(newArray, 0);

            BubbleSort(newArray);

            return newArray[newArray.Length - index];
        }


        /// <summary>
        /// Write a C# Sharp program to check whether a triangle can be formed by the given angles value
        /// </summary>
        /// <param name="angleA"></param>
        /// <param name="angleB"></param>
        /// <param name="angleC"></param>
        /// <returns></returns>
        public static bool CanFormTriangle(int angleA, int angleB, int angleC) {
            return (angleA + angleB + angleC) == 180;
        }

        public static void Execute()
        {
            Console.WriteLine(ReverseNumber(12345));

            Console.WriteLine(ReverseNumber(-23750));

            DisplayA();

            int[] arr1 = { 5, 7, 9, 3, 17 };
            Console.WriteLine(NLargestItemInArray(arr1, 2));
            int[] arr2 = { -4, -5, -11, -22};
            Console.WriteLine(NLargestItemInArray(arr2, 2));
            int[] arr3 = {-11, -22 };
            Console.WriteLine(NLargestItemInArray(arr3, 2));
            int[] arr4 = { 5, 75};
            Console.WriteLine(NLargestItemInArray(arr4, 2));
            

            Console.WriteLine(CanFormTriangle(90,45,45));
            Console.WriteLine(CanFormTriangle(30, 65, 85));
            Console.WriteLine(CanFormTriangle(40, 55, 65));

        }
    }

}
