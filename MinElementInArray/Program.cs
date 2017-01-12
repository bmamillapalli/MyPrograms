using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 4, 5, 8, 5, 2, 5, 100, 4, 85, 8 };

            int min = x[0];
            for (int i = 0; i < x.Length - 1; i++)
            {
                    if (min > x[i])
                        min = x[i];
            }
            Console.WriteLine("The Minimum Value in array is: " + min);


            

            int[] z = {1, 2, 3, 4, 5, 6, 7};
            int missing = 0,j=1;
           
            for (int i = 0; i < (z.Length-1); i++)
            {
                if (j != z[i])
                {
                    missing = j;
                    break;
                }
                j++;
            }
            Console.WriteLine("Missing: " + missing);

            Console.Read();
        }
    }
}
