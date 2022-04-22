using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for hollow triangle.");

            Console.WriteLine("Enter size of triangle ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Etner direction of triangle (u , d) ");
            char y = Convert.ToChar(Console.ReadLine());

            if (y == 'u')
            {
                for (int i = 1; i <= x - 1; i++)
                {
                    Console.Write("*");

                    if (i > 1)
                    {
                        for (int j = 1; j < i; j++)
                        {
                            Console.Write("  ");
                        }
                    }

                    if (i > 0)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
                
                for (int i = 0; i < x; i++)
                {
                    Console.Write("* ");
                }
            }

            if (y == 'd')
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                for (int i = x - 1; i > 0; i--)
                {
                    Console.Write("*");

                    if (i < x + 2)
                    {
                        for (int j = 0; j < i - 1; j++)
                        {
                            Console.Write("  ");
                        }

                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
