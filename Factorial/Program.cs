using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public int Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }

        public int RecursionFactorial(int x)
        {
            if ((x == 0) || (x == 1))
                return 1;
            else
                return (x* RecursionFactorial(x - 1));
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Which Method You Want?");
            Console.WriteLine("1. Recursion Function");
            Console.WriteLine("2. Using While Loop");
            int kb = Convert.ToInt32(Console.ReadLine());

            switch (kb)
            {
                case 1:
                    {
                        Console.WriteLine("Enter The Number For Which You Want The Factorial:");
                        int inpt = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("The Factorial of " + inpt + " is: " + obj.RecursionFactorial(inpt));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter The Number For Which You Want The Factorial:");
                        int inpt = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("The Factorial of " + inpt + " is: " + obj.Factorial(inpt));
                        break;
                    }
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
            Console.Read();
        }
    }
}
