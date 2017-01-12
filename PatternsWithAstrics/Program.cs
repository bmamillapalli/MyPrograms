using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsWithAstrics
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the no. of Rows:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Pattern 1
            Console.WriteLine("Pattern 1:");
            Console.WriteLine();
            for (int  i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            //Pattern 2
            Console.WriteLine();
            Console.WriteLine("Pattern 2:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Pattern 3
            Console.WriteLine();
            Console.WriteLine("Pattern 3:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Pattern 4
            Console.WriteLine();
            Console.WriteLine("Pattern 4:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-i-1); j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (i+1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Pattern 5
            Console.WriteLine();
            Console.WriteLine("Pattern 5:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k < n; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Pattern 6
            Console.WriteLine();
            Console.WriteLine("Pattern 6:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //Pattern 7
            Console.WriteLine();
            Console.WriteLine("Pattern 7:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((i * j) + " ");
                }
                Console.WriteLine();
            }

            //Pattern 8
            Console.WriteLine();
            Console.WriteLine("Pattern 8:");
            Console.WriteLine();
            int z = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(z + " ");
                    z++;
                }
                Console.WriteLine();
            }

            //Pattern 9
            Console.WriteLine();
            Console.WriteLine("Pattern 9:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-i); j++)
                {
                    Console.Write(" ");
                }
                for(int y= 0; y <=i; y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Pattern 10
            Console.WriteLine();
            Console.WriteLine("Pattern 10:");
            Console.WriteLine();
            for (int i = 0; i < (2 * n); i+=2)
            {
                for (int j = 0; j < (2 * n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= i; y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Pattern 11
            Console.WriteLine();
            Console.WriteLine("Pattern 11:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= i; y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= n-i; y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Pattern 12
            Console.WriteLine();
            Console.WriteLine("Pattern 12:");
            Console.WriteLine();
            for (int i = 0; i < (2 * n); i+=2)
            {
                for (int j = 0; j < (2 * n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= i; y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= (2 * n); i += 2)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= (2 * n - i); y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Pattern 13
            Console.WriteLine();
            Console.WriteLine("Pattern 13:");
            Console.WriteLine();
            for (int i = 0; i < (2*n); i++)
            {
                for (int j = 0; j < (2*n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= i; y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= (2*n); i+=2)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= (2*n - i); y++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            //Pattern 14
            Console.WriteLine();
            Console.WriteLine("Pattern 14:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= i; y++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= n - i; y++)
                {
                    Console.Write((n-i) + " ");
                }
                Console.WriteLine();
            }

            //Pattern 15
            Console.WriteLine();
            Console.WriteLine("Pattern 15:");
            Console.WriteLine();
            for (int i = 0; i < (2 * n); i += 2)
            {
                for (int j = 0; j < (2 * n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= i; y++)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= (2 * n); i += 2)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= (2 * n - i); y++)
                {
                    Console.Write(y + " ");
                }
                Console.WriteLine();
            }

            //Pattern 16
            Console.WriteLine();
            Console.WriteLine("Pattern 16:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= i; y++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int y = 0; y <= n - i; y++)
                {
                    Console.Write((n - i) + " ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
