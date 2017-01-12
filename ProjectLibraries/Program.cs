using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryToDecimalLibraries;
using FactorialLibraries;

namespace ProjectLibraries
{
    class Projects
    {
        public string BinaryToDecimal()
        {
            Console.WriteLine("Enter the number that needs to be converted into Binary");
            int a = Convert.ToInt32(Console.ReadLine());

            BinaryToDecimal obj = new BinaryToDecimal();
            string str = obj.B2D(a);
            return str;
        }
        public int Fact()
        {
            Console.WriteLine("Enter The Number For Which You Want The Factorial:");
            int a = Convert.ToInt32(Console.ReadLine());

            Factorial obj = new Factorial();
            int fact = obj.Fact(a);
            return fact;
        }
        static void Main(string[] args)
        {
            Projects obj = new Projects();

            Console.WriteLine(obj.BinaryToDecimal());
            Console.WriteLine();
            Console.WriteLine(obj.Fact());

            Console.Read();
        }
    }
}
