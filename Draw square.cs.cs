using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for draw square.");

            Console.WriteLine("Enter a number for side of square ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
