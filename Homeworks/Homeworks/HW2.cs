using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homeworks.Utils;

namespace Homeworks
{
    public static class HW2
    {
        private static void SwapTwoNumbers<T>(ref T num1, ref T num2)
        {
            (num1, num2) = (num2, num1);
        }

        /// <summary>
        ///-- print the sum of two numbers
        ///-- print the result of dividing two numbers
        ///-- print the result of the specified operations 
        ///-1 + 4 * 6
        ///( 35+ 5 ) % 7
        ///14 + -4 * 6 / 11
        ///2 + 15 / 6 * 1 - 7 % 2
        /// </summary>
        public static void Task1()
        {
            double[] numbersFromConsole = ConsoleUtils.GetTwoNumbersFromConsole();

            Console.WriteLine($"{numbersFromConsole[0]} + {numbersFromConsole[1]} =  {numbersFromConsole[0] + numbersFromConsole[1]}");
            Console.WriteLine($"{numbersFromConsole[0]} / {numbersFromConsole[1]} =  {numbersFromConsole[0] / numbersFromConsole[1]}");


            Console.WriteLine("-1 + 4 * 6 ={0}", (-1d + 4d * 6d));
            Console.WriteLine(" 35+ 5 ) % 7 ={0}", ((35d + 5d) % 7));
            Console.WriteLine("14 + -4 * 6 / 11 ={0}", (14d + -4d * 6d / 11d));
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 ={(2d + 15d / 6d * 1d - 7d % 2d)}" );
        }


        /// <summary>
        /// -- swap two numbers
        /// </summary>
        public static void Task2()
        {
            double[] numbersFromConsole = ConsoleUtils.GetTwoNumbersFromConsole();

            SwapTwoNumbers(ref numbersFromConsole[0], ref numbersFromConsole[1]);

            Console.WriteLine($"{numbersFromConsole[0]}");
            Console.WriteLine($"{numbersFromConsole[1]}");
        }

        /// <summary>
        /// -- print the output of multiplication of three numbers which will be entered by the user 
        /// </summary>
        public static void Task3()
        {
            double[] numbersFromConsole = ConsoleUtils.CollectArraytOfNumbersFromConsole(3);

            double result = numbersFromConsole[0];
            Console.WriteLine("Result of multiplication:");

            Console.Write(numbersFromConsole[0]);

            for (int i = 1; i < numbersFromConsole.Length; i++)
            {
                result *= numbersFromConsole[i];
                Console.Write($" х {numbersFromConsole[i]}");
            }
            Console.Write($" = {result}");

            Console.WriteLine();
        }

        public static void Execute() {
            HW2.Task1();
            HW2.Task2();
            HW2.Task3();
        }
    }
}



