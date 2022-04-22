using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golden_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for golden number.");

            Console.WriteLine("enter number to Divine Proportion: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y, z;

            y = (int)(x / 1.618);
            z = (int)(x * 1.618);

            Console.WriteLine("If your number is length, the ratio is: " + y);
            Console.WriteLine("If your number is width, the ratio is: " + z);

            Console.ReadKey();
        }
    }
}
