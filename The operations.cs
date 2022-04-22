using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for operations.");

            Console.WriteLine("Enter number for array length ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[x];

            int sum = 0;

            double avg = 0, b = 0;
            int stash, pow, div, var = 0;

            Console.WriteLine("Enter your numbers ");
            for (int i = 0; i < x; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                sum += a[i];
            }

            int min = a[0], max = a[1];

            for (int i = 0; i < x; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }

            avg = sum / x;
            b = avg;

            for (int i = 0; i < x; i++)
            {
                stash = Convert.ToInt32(a[i] = (int)b);
                pow = stash * stash;
                div = pow / x;
                var += div;
            }

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);
            Console.WriteLine("Varians: " + var);

            Console.ReadKey();
        }
    }
}
