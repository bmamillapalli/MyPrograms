using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Enter a number for that Table:");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(a + "*" + i + "=" + (a * i));
            }

            ////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Multplication Table Till 20");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int j,i = 1; i <= 20; i++)
            {
                for(j = 1; j <= 20; j++)
                {
                    //Console.Write(Math.Floor(Math.Log10(i * j) + 1));
                     if((Math.Floor(Math.Log10(i * j) + 1)) == 3)
                        Console.Write("{0}  ", i * j);
                    else if ((Math.Floor(Math.Log10(i * j) + 1)) == 2)
                        Console.Write("{0}   ", i * j);
                    else
                        Console.Write("{0}    ", i * j);
                }
                    Console.WriteLine();
            }
            Console.Read();
        }
    }
}
