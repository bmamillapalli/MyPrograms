using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionsWithSwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In Which Scale do you Want to Enter The Degrees?");
            Console.WriteLine("1.Celsius");
            Console.WriteLine("2.Fahrenheit");
            Console.WriteLine("3.Kelvin");

            int c, f, k;
            int scale = Convert.ToInt32(Console.ReadLine());

            switch (scale)
            {
                case 1:

                    Console.WriteLine("Enter the Degrees in Celsius");
                    c = Convert.ToInt32(Console.ReadLine());
                    f = (9 * c / 5) + 32;
                    k = 273 + c;
                    Console.WriteLine("The Temperature in Farenheit is :" + f);
                    Console.WriteLine("The Temperature in Kelvin is    :" + k);

                    break;
                case 2:

                    Console.WriteLine("Enter the Degrees in Farenheit");
                    f = Convert.ToInt32(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    k = 273 + c;
                    Console.WriteLine("The Temperature in Celsius is :" + c);
                    Console.WriteLine("The Temperature in Kelvin is  :" + k);

                    break;
                case 3:

                    Console.WriteLine("Enter the Degrees in Kelvin");
                    k = Convert.ToInt32(Console.ReadLine());
                    c = k - 273;
                    f = (9 * c / 5) + 32;
                    Console.WriteLine("The Temperature in Celsius is   :" + c);
                    Console.WriteLine("The Temperature in Farenheit is :" + f);

                    break;
                default:
                    Console.WriteLine("     ERROR   ");
                    Console.WriteLine("PLease ReRun the Program");
                    break;
            }
            Console.Read();
        }
    }
}
