using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_Pow_y
{
    class Program
    {
        static void Main(string[] args)
        {
            // subtitle
            Console.WriteLine("This project is for x pow y.");

            // variables & input
            Console.WriteLine("Enter first number ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int y = Convert.ToInt32(Console.ReadLine());

            int stash = 1;

            // operation
            for (int i = 0; i < y; i++)
            {
                stash *= x;
            }

            // output
            Console.WriteLine("x pow y: " + stash);

            Console.ReadKey();
        }
    }
}
