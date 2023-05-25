using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks.Utils
{
   public static  class ConsoleUtils
    {

        public static double[] GetTwoNumbersFromConsole() {
            double num1 = 0, num2 = 0;

            bool flag;

            do
            {
                flag = true;
                Console.WriteLine("Input number1: ");
                flag = flag && Double.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine("Input number2: ");
                flag = flag && Double.TryParse(Console.ReadLine(), out num2);

                if (!flag)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Data Entered\n Re-enter numbers");
                }

            } while (!flag);

            return  new double[] { num1, num2 };
        }

        public static double[] CollectArraytOfNumbersFromConsole(int quantity)
        {
            double[] numbers = new double[quantity];

            for (int i = 0; i < quantity; i++)
            {
                bool flag;
                do
                {
                    Console.WriteLine($"Input number{i+1}: ");
                    flag = Double.TryParse(Console.ReadLine(), out numbers[i]);

                    if (!flag)
                    {
                        Console.WriteLine("Wrong Data Entered\n Re-enter numbers");
                    }

                } while (!flag);

            }

            return numbers;
        }
    }
}
