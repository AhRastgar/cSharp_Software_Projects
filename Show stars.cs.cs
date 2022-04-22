using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for show stars.");

            Console.WriteLine("Enter number of stars for draw a star: ");
            int x = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("* ");
            }

            Console.ReadKey();
        }
    }
}
