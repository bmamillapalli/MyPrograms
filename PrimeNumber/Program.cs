using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number To Check Weather The Number Is A Prime Number or Not:");
            int n = Convert.ToInt32(Console.ReadLine());

            
            int rem, k = 0, pro, Lfactor=0;
            bool flag=false;

            int[] factors = new int[n/2];
            for (int i = 1; i <= n/2; i++)
            {
                rem = n % i;
                if (rem == 0)
                    k++;

                if (k > 1)
                {
                    pro = n % i;
                    if (pro == 0)
                    {
                        if (flag == false)
                        {
                            Console.WriteLine("Factors are: ");
                            flag = true;
                        }
                        factors[Lfactor] = i;
                        Console.Write(factors[Lfactor] + ",");
                        Lfactor++;
                    }
                }
            }

            if (k == 1) 
                    Console.WriteLine("The Number is a Prime Number");
            else
            {
                Console.WriteLine("\n\n\nThe Number is Not a Prime Number");
                Console.WriteLine("\nHighest Factor is:" + factors[Lfactor-1]);
                Console.WriteLine("\nLowest Factor is:" + factors[0]);
            }

            Console.Read();
        }
    }
}
