using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expansion_of_pi_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for ecpansion of pi number.");

            Console.WriteLine("Enter your number ");
            int x = Convert.ToInt32(Console.ReadLine());
            float p = 3.14F;
            double stash = 2 * p * x;
            double pi = stash / x;

            Console.WriteLine("The expansion of pi number is: " + pi);

            Console.ReadKey();
        }
    }
}
