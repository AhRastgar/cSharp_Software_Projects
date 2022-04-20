using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for average between numbers.");

            Console.WriteLine("Enter your numbers ");
            int[] x = new int[5];
            int stash = 0;

            for (int i = 0; i < 5; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
                stash += x[i];
            }

            Console.WriteLine("Average: " + stash / 5);

            Console.ReadKey();
        }
    }
}
