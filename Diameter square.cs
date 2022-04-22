using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_square
{
    internal class Program
    {
        static void square(int length)
        {
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= length; j++)
                {
                    if (i == j)
                    {
                        Console.Write("* ");
                    }
                    else if (j == (length + 1) - i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for hollow square.");

            Console.WriteLine("Enter number for side of square ");
            int x = Convert.ToInt32(Console.ReadLine());

            square(x);

            Console.ReadKey();
        }
    }
}