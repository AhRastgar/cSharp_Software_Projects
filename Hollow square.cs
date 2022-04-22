using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for hollow square.");

            Console.WriteLine("Enter number for side of square ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            for (int i = 0; i < x - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < 2 * x - 3; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }

            for (int i = 0; i < x; i++)
            {
                Console.Write("* ");
            }

            Console.ReadKey();
        }
    }
}
