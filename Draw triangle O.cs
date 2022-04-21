using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_triangle_O
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for draw triangle O.");

            Console.WriteLine("Enter number for side of triangle ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

                for (int k = i; k <= x; k++)
                {
                    Console.Write("  ");
                }
            }

            Console.ReadKey();
        }
    }
}
