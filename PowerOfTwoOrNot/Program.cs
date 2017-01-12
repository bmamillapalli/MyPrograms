using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwoOrNot
{
    class Program
    {
        public void Power()
        {
            Console.WriteLine("Enter The Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int y = 0,power=0;
            while ((y == 0) || (x == 0))
            {
                x = x / 2;
                y = x % 2;
                power++;
               // Console.WriteLine(x + "--" + y);
            }
            if ((y == 1) && (x != 1))
                Console.WriteLine("Entered Number is Not A Power Of 2");
            if (x == 1)
                Console.WriteLine("Entered Number is A Power Of 2" + "\nPower is: " + power);

        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            obj.Power();

            Console.Read();
        }
    }
}
