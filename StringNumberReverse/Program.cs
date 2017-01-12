using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringNumberReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to reverse?");
            Console.WriteLine("1.Number");
            Console.WriteLine("2.String");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:

                    Console.WriteLine();
                    Console.WriteLine("Enter the number you want to reverse:");
                    int a = Convert.ToInt32(Console.ReadLine());

                    int rem,rev=0;

                    while (a > 0)
                    {
                        rem = a % 10;
                        rev = (rev * 10) + rem;
                        a = a / 10;
                    }
                    
                    Console.WriteLine("The Reverse of the number is:"+rev);

                    break;

                case 2:

                    Console.WriteLine();
                    Console.WriteLine("Enter the string you want to reverse:");
                    string str = Console.ReadLine();

                    char[] c;
                    c = str.ToCharArray();

                    for(int i = (str.Length-1); i >=0; i--)
                    {
                        Console.Write(c[i]);
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
