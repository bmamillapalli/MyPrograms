using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string bin="";
            int rem;

            Console.WriteLine("Enter the number that needs to be converted into Binary");
            int a = Convert.ToInt32(Console.ReadLine());

            while (a > 1)
            {
                rem = a % 2;
                bin = Convert.ToString(rem) + bin;
                a = a / 2;
            }
            bin = Convert.ToString(a) + bin;
            Console.WriteLine(bin);
            Console.Read();
        }
    }
}
