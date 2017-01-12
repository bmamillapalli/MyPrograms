using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteCSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your House No.:");
            string hno = Console.ReadLine();
            Console.WriteLine("Enter Your Street:");
            string street = Console.ReadLine();
            Console.WriteLine("Enter Your City:");
            string city = Console.ReadLine();
            Console.WriteLine("Enter Your Zipcode:");
            int zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("============================");
            Console.WriteLine("The Address is:");
            Console.WriteLine(name);
            Console.WriteLine(hno);
            Console.WriteLine(street);
            Console.WriteLine(city);
            Console.WriteLine(zip);
            Console.WriteLine("============================");

            Console.ReadLine();


        }
    }
}
