using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_between_2_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // subtitle
            Console.WriteLine("This project is for product odd between 2 numbers.");

            // variables & input
            Console.WriteLine("Enter first number ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int y = Convert.ToInt32(Console.ReadLine());

            int stash = 1;

            // opearation
            for (int i = x; i <= y; i++)
            {
                if (i % 2 == 1)
                {
                    stash *= i;
                }
            }

            // output
            Console.WriteLine("Product odd number between 2 number: " + stash);

            Console.ReadKey();
        }
    }
}
