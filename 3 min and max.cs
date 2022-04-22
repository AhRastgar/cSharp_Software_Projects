using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_min_and_max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for 3 minimum & maximum.");

            Console.WriteLine("Enter number for array length ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[x];

            Console.WriteLine("Enter your numbers ");
            if (x >= 5)
            {
                for (int i = 0; i < x; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            int min = a[0];
            int max = a[x - 1];
            int counter1 = 0, counter2 = 0;

            if (x >= 5)
            {
                for (int i = 0; i < x; i++)
                {
                    if (a[i] > min)
                    {
                        min = a[i];
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        counter1++;

                        Console.WriteLine("3 minimum is: " + min);
                    }
                    if (counter1 == 3)
                    {
                        break;
                    }
                }
            }

            if (x >= 5)
            {
                for (int i = x - 1; i > 0; i--)
                {
                    if (a[i] < max)
                    {
                        max = a[i];
                    }
                    for (int j = 0; j < 1; j++)
                    {
                        counter2++;

                        Console.WriteLine("3 maximum is: " + max);
                    }
                    if (counter2 == 3)
                    {
                        break;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
