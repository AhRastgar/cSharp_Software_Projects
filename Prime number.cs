using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for prime number.");

            Console.WriteLine("Enter your number ");
            int x = Convert.ToInt32(Console.ReadLine());

            int b = 0;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    b = 1;
                }
            }

            if (b == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
