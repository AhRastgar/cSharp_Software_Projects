using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow
{
    class Program
    {
        static void Main(string[] args)
        {
            // subtitle
            Console.WriteLine("This project is for pow.");

            // variables & input
            Console.WriteLine("Enter a number for pow ");
            int a = Convert.ToInt32(Console.ReadLine());

            // operation & output
            Console.WriteLine("pow 1: " + a);
            Console.WriteLine("pow 2: " + a * a);
            Console.WriteLine("pow 3: " + a * a * a);

            Console.ReadKey();
        }
    }
}
