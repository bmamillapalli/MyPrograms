using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select What you want to do?");
            Console.WriteLine("1.Check Even or Odd");
            Console.WriteLine("2.Print Even or Odd Numbers");
            int sel = Convert.ToInt32(Console.ReadLine());

            switch (sel)
            {
                case 1:

                    Console.WriteLine();
                    Console.WriteLine("Enter The number you want to check");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a % 2 == 0)
                        Console.WriteLine("Its a Even Number");
                    else
                        Console.WriteLine("Its a Odd Number");
                    break;
                case 2:

                    Console.WriteLine("Enter the range of numbers you want to print");
                    Console.WriteLine("Enter the starting point:");
                    int p = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the ending point:");
                    int q = Convert.ToInt32(Console.ReadLine());

                    if (p > q)
                    {
                        Console.WriteLine("The higher limit should be greater than lower limit.");
                    }
                    else
                    {
                        Console.WriteLine("The Even Numbers are:");
                        for (int i = p; i <= q; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.Write(i + ",");
                            }
                        }
                        Console.Write("\n");
                        Console.WriteLine("The Odd Numbers are:");
                        for (int i = p; i <= q; i++)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(i + ",");
                            }
                        }
                    }
                    break;

                default:

                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.Read();
        }
    }
}
