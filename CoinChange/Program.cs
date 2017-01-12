using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinChange
{
    class Program
    {
        public void CoinChangeApp()
        {
            Console.WriteLine("Enter The Change:");
            decimal x = Convert.ToDecimal(Console.ReadLine());

            int h = 0, fty = 0, tty = 0, t = 0, f = 0, s = 0, q = 0, d = 0, n = 0, p = 0;
            while (x != 0)
            {
                while (x >= 100M)
                {
                    x -= 100M;
                    h++;
                }
                while (x >= 50M)
                {
                    x -= 50M;
                    fty++;
                }
                while (x >= 20M)
                {
                    x -= 20M;
                    tty++;
                }
                while (x >= 10M)
                {
                    x -= 10M;
                    t++;
                }
                while (x >= 5M)
                {
                    x -= 5M;
                    f++;
                }
                while (x >= 1M)
                {
                    x -= 1M;
                    s++;
                }
                while (x >= 0.25M)
                {
                    x -= 0.25M;
                    q++;
                }
                while (x >= 0.10M)
                {
                    x -= 0.10M;
                    d++;
                }
                while (x >= 0.05M)
                {
                    x -= 0.05M;
                    n++;
                }
                while (x >= 0.01M)
                {
                    x -= 0.01M;
                    p++;
                }
            }

            if (h > 0)
                Console.WriteLine("Hunder's:" + h);
            if (fty > 0)
                Console.WriteLine("Fifty's:" + fty);
            if (tty > 0)
                Console.WriteLine("Twenty's:" + tty);
            if (t > 0)
                Console.WriteLine("Ten's:" + t);
            if (f > 0)
                Console.WriteLine("Five's:" + f);
            if (s > 0)
                Console.WriteLine("Single's:" + s);
            if (q > 0)
                Console.WriteLine("Quaters:" + q);
            if (d > 0)
                Console.WriteLine("Dimes:" + d);
            if (n > 0)
                Console.WriteLine("Nickels:" + n);
            if (p > 0)
                Console.WriteLine("Pennies:" + p);

            Console.Read();
        }
        public void AddingMachineApp()
        {
            int h , fty , tty, t, f , s, q, d, n, p; 
            double total = 0;

            Console.Write("Enter The Number of Quarters:");
            q = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Dimes:");
            d = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Nikels:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Pennies:");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Ones:");
            s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Fives:");
            f = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Tens:");
            t = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Twenties:");
            tty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Fifties:");
            fty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter The Number of Hundreds:");
            h = Convert.ToInt32(Console.ReadLine());

            total = (0.25 * q) + (0.10 * d) + (0.05 * n) + (0.01 * p) + (1 * s) + (5 * f) + (10 * t) + (20 * tty) + (50 * fty) + (100 * h);

            Console.WriteLine("Total :" + total);

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            Console.WriteLine("Which Application You want to Open?");
            Console.WriteLine("1. Coin Change App");
            Console.WriteLine("2. Addition Machine App");
            int sel = Convert.ToInt32(Console.ReadLine());

            switch (sel)
            {
                case 1:
                    obj.CoinChangeApp();
                    break;
                case 2:
                    obj.AddingMachineApp();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
