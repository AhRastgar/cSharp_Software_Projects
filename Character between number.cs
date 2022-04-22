using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_between_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for deploy character between numbers.");

            Console.WriteLine("Enter your number ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your character ");
            char y = Convert.ToChar(Console.ReadLine());

            int s1, rev1 = 0;

            for (int i = x; 0 < x; i++)
            {
                s1 = x % 10;
                x /= 10;
                rev1 = rev1 * 10 + s1;
            }

            for (int i = rev1; 0 < rev1; i++)
            {
                s1 = rev1 % 10;
                rev1 /= 10;
                Console.Write(s1);
                Console.Write(y);
            }

            Console.ReadKey();
        }
    }
}
