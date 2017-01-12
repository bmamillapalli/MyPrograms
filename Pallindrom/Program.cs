using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String to check wheather it is a pallindrom or not?");
            string str = Console.ReadLine();
            string revstr = "";
            char[] c;
            c = str.ToCharArray();
            for (int i = (str.Length-1); i >= 0; i--)
            {
                revstr = revstr + c[i];
            }
                
            if (str.Equals(revstr))
                Console.WriteLine("The String is a Pallindrom");
            else
                Console.WriteLine("The String is Not a Pallindrom");

            Console.Read();

        }
    }
}
