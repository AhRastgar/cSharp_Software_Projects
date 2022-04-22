using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for palindrom.");

            Console.WriteLine("Enter your number ");
            int x = Convert.ToInt32(Console.ReadLine());

            int num = x;
            int stash = 0, reverse = 0;

            if (x > 0)
            {
                while (x > 0)
                {
                    stash = x % 10;
                    x = x / 10;
                    reverse = reverse * 10 + stash;
                }
            }

            if (num == reverse)
            {
                Console.WriteLine("This is a palindrom.");
            }
            else
            {
                Console.WriteLine("This is not a palindrom.");
            }

            Console.ReadKey();
        }
    }
}
