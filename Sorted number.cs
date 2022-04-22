using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for descending & ascending.");

            Console.WriteLine("Enter number for array length ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] y = new int[x];

            Console.WriteLine("Enter your numbers ");
            for (int i = 0; i < x; i++)
            {
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = y[0];

            Console.WriteLine("Descending: ");
            for (int j = 0; j < x; j++)
            {
                min = y[j];
                Console.Write(min + " ");
            }
            Console.WriteLine();

            int max = y[x - 1];

            Console.WriteLine("Ascending: ");
            for (int l = x - 1; l >= 0; l--)
            {
                max = y[l];
                Console.Write(max + " ");
            }

            Console.ReadKey();
        }
    }
}
