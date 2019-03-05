using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503HW
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question2_InputAndPrint();

            //Console.Write("Enter a numbner between 1-10: ");

            //int x = Convert.ToInt32(Console.ReadLine());

            //Question3_InputAndPrint(x);

            Console.Write("Enter a numbner between 1-10: ");

            int x = Convert.ToInt32(Console.ReadLine());

            bool isInRange = Question4_InputAndPrint(x);
            if (isInRange) // == true
            {
                Console.WriteLine("Number is in range 1-10");
            }
            else
            {
                Console.WriteLine("Number is NOT in range 1-10");
            }

            Print1To10(1);
        }

        /// <summary>
        /// This is a recursive method (for fun)
        /// </summary>
        /// <param name="x"></param>
        static void Print1To10(int x)
        {
            Console.WriteLine(x);
            if (x < 11)
            {
                Print1To10(x + 1);
            }
        }

        private static bool Question4_InputAndPrint(int y)
        {
            switch (y)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                default:
                    Console.WriteLine($"The number {y} is not in range");
                    return false;
            }
            return true;

        }

        private static void Question3_InputAndPrint(int y)
        {
            switch (y)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                default:
                    Console.WriteLine($"The number {y} is not in range");
                    break;
            }
        }

        private static void Question2_InputAndPrint()
        {
            Console.Write("Enter a numbner between 1-10: ");

            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;
                default:
                    Console.WriteLine($"The number {x} is not in range");
                    break;
            }
        }
    }
}
