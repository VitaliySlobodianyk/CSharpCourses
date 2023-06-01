using Homeworks.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    internal class HW3
    {
        private static bool IsPrime(int number)
        {
            const int minimalDivider = 2;

            if (number < minimalDivider) { return false; }

            for (int i = minimalDivider; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Write a C# program to check two given integers and return true if one is negative and one is positive.
        /// </summary>
        public static void Task1()
        {
            Console.WriteLine("a C# program to check two given integers and return true if one is negative and one is positive.");

            double[] numbers = ConsoleUtils.GetTwoNumbersFromConsole();

            Console.WriteLine($"Check if one is negative and one is positive {(numbers[0] * numbers[1] < 0)}");
        }

        /// <summary>
        /// Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
        /// </summary>
        public static void Task2()
        {
            Console.WriteLine("a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.");

            const int desiredValue = 20;

            double[] numbers = ConsoleUtils.GetTwoNumbersFromConsole();

            Console.WriteLine($" if one of the integer is 20 or if their sum is 20. {numbers[0] == desiredValue || numbers[1] == desiredValue || numbers[0] + numbers[1] == desiredValue}");
        }
        /// <summary>
        /// Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
        /// </summary>
        public static void Task3()
        {
            Console.WriteLine("a C# program to print the odd numbers from 1 to 99. Prints one number per line.");

            const int upperBound = 99;
            const int lowerOddNumber = 1;
            Console.WriteLine("print the odd numbers from 1 to 99");
            for (int i = lowerOddNumber; i <= upperBound; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Write a C# program to compute the sum of the first 500 prime numbers
        /// </summary>
        public static void Task4()
        {
            Console.WriteLine("a C# program to compute the sum of the first 500 prime numbers.");

            const int amountOfPrimeNumbers = 500;

            int sum = 0;
            for (int currentNumber = 1, currentAmountOfPrimeNumbers = 0; currentAmountOfPrimeNumbers < amountOfPrimeNumbers; currentNumber++)
            {
                if (IsPrime(currentNumber))
                {
                    sum += currentNumber;
                    currentAmountOfPrimeNumbers++;
                }
            }

            Console.WriteLine($" Sum of the first {amountOfPrimeNumbers} prime numbers: {sum}");
        }

        /// <summary>
        /// Write a C# program and compute the sum of the digits of an integer.
        /// </summary>
        public static void Task5()
        {
            Console.WriteLine("a C# program and compute the sum of the digits of an integer.");

          int num = ConsoleUtils.GetIntegerNumberFromConsole("Input a number(integer):");
            string digits = Math.Abs(num).ToString().Trim();

            int sumofNumbers = 0;
            foreach (char digit in digits)
            {
                sumofNumbers += Int32.Parse(digit.ToString());
            }

            Console.WriteLine($"Sum of the digits of the {num} integer: {sumofNumbers}");
        }

        public static void Execute()
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
        }
    }
}
