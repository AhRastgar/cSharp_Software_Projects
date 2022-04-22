using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisor_against
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for divisor against.");

            Console.WriteLine("Enter your nubmer ");
            int x = Convert.ToInt32(Console.ReadLine());
            int num = x;
            int sum = 0;

            Console.WriteLine("Divide by your number is ");

            for (int i = 1; i <= x; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
