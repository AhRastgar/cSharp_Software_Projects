using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_triangle_Z
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for draw triangle Z.");

            Console.WriteLine("Enter number for side of triangle ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
