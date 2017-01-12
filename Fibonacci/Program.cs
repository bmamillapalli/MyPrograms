using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        public void Fib(int x)
        {
            int a = 0, b = 1, c;

            if (x == 0)
            {
                Console.Write("");
            }
            if (x == 1)
            {
                Console.Write("" + a);
            }
            if (x >= 2)
            {
                Console.Write("" + a + "," + b);

                for (int i = 0; i < (x - 2); i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    Console.Write("," + c);
                }
            }
        }
        
        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Enter The Number Of Terms In The series:");
            int y = Convert.ToInt32(Console.ReadLine());

            obj.Fib(y);

            Console.Read();
        }
    }
}
