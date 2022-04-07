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
            Console.WriteLine("Enter a number for radius of the circle ");
            float r = Convert.ToSingle(Console.ReadLine());
            float p = 3.14F;

            // operation & output
            Console.WriteLine("circle diameter: " + r * 2);
            Console.WriteLine("circle perimeter: " + 2 * p * (r * r));
            Console.WriteLine("circle area: " + p * (r * r));

            Console.ReadKey();
        }
    }
}