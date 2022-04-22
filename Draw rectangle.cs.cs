using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for draw rectangle.");

            Console.WriteLine("Enter length of rectangle ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width of rectangle ");
            int y = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
