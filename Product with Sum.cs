using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_with_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            // subtitle
            Console.WriteLine("This project is for Product with Sum.");

            // variables & input
            Console.WriteLine("Enter first number ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int y = Convert.ToInt32(Console.ReadLine());

            int stash = 0;

            // opearation
            for (int i = 0; i < y; i++)
            {
                stash += x;
            }

            // output
            Console.WriteLine("Product with Sum: " + stash);

            Console.ReadKey();
        }
    }
}
