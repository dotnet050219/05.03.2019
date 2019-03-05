using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            //StarsPrint();

            Rishoni();
        }

        private static void Rishoni()
        {
            int sum = 0;
            int number = 0;

            do
            {
                sum = sum + number;
                Console.WriteLine("Enter numbers (non-prime to exit):");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (IsPrime(number));

            Console.WriteLine($"Sum = {sum}");
        }

        private static bool IsPrime(int number)
        {
            int m = 2;

            if (number == 1)
                return true;

            while (number % m != 0)
            {
                m++;
            }

            if (number == m)
                return true;
            else
                return false;
        }

        private static void StarsPrint()
        {
            int stars = Convert.ToInt32(Console.ReadLine());

            for (int i = stars; i >= 1; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
