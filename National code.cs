using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace National_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This project is for national code.");

            Console.WriteLine("Enter your national number ");
            string x = (Console.ReadLine());
            int v = Convert.ToInt32(x);

            switch (x)
            {
                case "0000000000":
                case "1111111111":
                case "2222222222":
                case "3333333333":
                case "4444444444":
                case "5555555555":
                case "6666666666":
                case "7777777777":
                case "8888888888":
                case "9999999999":
                    Console.WriteLine("This national code incorrect...!!");
                    break;
            }

            int a, b, c;
            a = x[9];
            b = ((x[0] * 10) + (x[1] * 9) + (x[2] * 8) + (x[3] * 7) + 
                (x[4] * 6)+ (x[5] * 5) + (x[6] * 4) + (x[7] * 3) + (x[8] * 2));
            c = b - ((b / 11) * 11);

            if ((c == 0) && (a == c) || (c == 1) && (a == 1) || (c > 1) && (a == Math.Abs((int)(c - 11))))
            {
                Console.WriteLine("This national code is correct.");
            }
            else
            {
                Console.WriteLine("This national code is incorrect...!!!");
            }

            Console.ReadKey();
        }
    }
}
