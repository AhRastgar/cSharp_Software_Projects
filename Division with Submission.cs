using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionwithSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // subtitle
            Console.WriteLine("This project is for Division with Submission.");

            // variables & input
            Console.WriteLine("Enter first number ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number ");
            int y = Convert.ToInt32(Console.ReadLine());

            int stNum = x;
            int counter = 0;

            // opearation
            for (int i = 0; ; i++)
            {
                if (stNum >= y)
                {
                    counter++;
                    stNum -= y;
                }
                else
                {
                    break;
                }
            }

            // output
            Console.WriteLine("Division with Submission: " + counter);

            Console.ReadKey();
        }
    }
}