using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for draw circle.");

            Console.WriteLine("Enter radius of the circle ");
            float x = Convert.ToInt32(Console.ReadLine());
            float k;

            float y = 2F;

            for (float i = -x; i <= x; i++)
            {
                for (float j = -x; j <= x; j++)
                {
                    k = (((i * y) / x) * ((i * y) / x) + (j / x) * (j / x));
                    if (k > 0.95 && k < 1.08)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
