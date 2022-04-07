using System;

namespace Radiusofthecircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // subtitle
            Console.WriteLine("This project is for radius of the circle.");

            // variables & input
            Console.WriteLine("Enter a triangle chord ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter two side of the triangle ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            // operation & output
            if (a < b + c)
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