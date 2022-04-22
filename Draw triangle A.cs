using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_triangle_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for draw triangle A.");

            Console.WriteLine("Enter number for side of triangle ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
