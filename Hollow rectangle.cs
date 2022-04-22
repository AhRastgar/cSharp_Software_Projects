using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for hollow rectangle.");

            Console.WriteLine("Enter length of rectangle ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            
            for (int i = 0; i < y - 2; i++)
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