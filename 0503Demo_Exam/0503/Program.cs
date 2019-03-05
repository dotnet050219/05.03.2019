using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503
{
    class Program
    {
        static void Main(string[] args)
        {
            Jump7();

            Console.WriteLine("=========================");
            Console.WriteLine();

            PrintTriangle();

            Console.WriteLine("=========================");
            Console.WriteLine();

            Bank();
        }

        private static void Bank()
        {
            int sum = Convert.ToInt32(Console.ReadLine());

            int bill200 = sum / 200;
            sum = sum % 200;

            int bill100 = sum / 100;
            sum = sum % 100;

            int bill50 = sum / 50;
            sum = sum % 50;

            int bill20 = sum / 20;
            sum = sum % 20;

            int coin5 = sum / 5;
            sum = sum % 5;

            Console.WriteLine($"200 x {bill200} ... 100 x {bill100} ... 50 x {bill50} ... 20 x {bill20} ... 5 x {coin5} ... ramining : {sum} 1 coins");

        }

        private static void PrintTriangle()
        {
            for (int i = 1; i <= 5 ; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        private static void Jump7()
        {
            for (int i = 7; i <= 100; i = i + 7)
            {
                Console.WriteLine(i);
            }
        }

    }
}
