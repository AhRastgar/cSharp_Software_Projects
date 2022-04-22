using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compelete_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for complete number.");

            Console.WriteLine("Enter your number ");
            int x = Convert.ToInt32(Console.ReadLine());
            int num = x;

            int sum = 0;

            for (int i = 1; i < x; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == x)
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
