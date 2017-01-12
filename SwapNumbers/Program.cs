using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter Number 1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please Select a method:");
            Console.WriteLine("1.Using Three Variables");
            Console.WriteLine("2.Using Two Variables");
            int sel = Convert.ToInt32(Console.ReadLine());

            switch (sel)
            {
                case 1:

                    c = a;
                    a = b;
                    b = c;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("*********  After Swapping  With Three Variables************");
                    Console.WriteLine();
                    Console.WriteLine("The First Number is: " + a);
                    Console.WriteLine("The Second Number is: " + b);

                    break;
                case 2:

                    a = a + b;
                    b = a - b;
                    a = a - b;

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("*********  After Swapping  The Swapped Numbers With Only Two Variables************");
                    Console.WriteLine();
                    Console.WriteLine("The First Number is: " + a);
                    Console.WriteLine("The Second Number is: " + b);

                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Please Check Your Choice");
                    break;
            }
           

            ///////////////////////////////////////////////////////////////////////////////

            Console.Read();
        }
    }
}
