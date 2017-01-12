using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Enter which way you want to do your operations?");
            Console.WriteLine("1.All Operations Together");
            Console.WriteLine("2.Individual Operations");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:

                    int a, b;
                    Console.WriteLine("Enter the First Number:");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The Sum of Two Numbers is " + (a + b));
                    Console.WriteLine("The Sub of Two Numbers is " + (a - b));
                    Console.WriteLine("The Mul of Two Numbers is " + (a * b));
                    Console.WriteLine("The Div of Two Numbers is " + (a / b));

                    break;
                case 2:

                    int p, q;
                    Console.WriteLine("Enter the First Number:");
                    p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second number:");
                    q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter any operator(+,-,/,*):");
                    char o = Convert.ToChar(Console.ReadLine());

                    if (o == '+')
                        Console.WriteLine("The Sum of Two Numbers is " + (p + q));
                    else if (o == '-')
                        Console.WriteLine("The Sub of Two Numbers is " + (p - q));
                    else if (o == '*')
                        Console.WriteLine("The Mul of Two Numbers is " + (p * q));
                    else if (o == '/')
                        Console.WriteLine("The Div of Two Numbers is " + (p / q));
                    else
                        Console.WriteLine("Invalid Operators Try Again");

                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }

            Console.Read();
        }
    }
}

