using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class Program
    {

        public void SimpleCal()
        {
            int a, tot = 0;
            char c;

/*            try
            {*/
                Console.Write("Enter the number:");
                a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the Operator:");
                c = Convert.ToChar(Console.ReadLine());

                if ((c == '+') || (c == '-') || (c == '*') || (c == '/'))
                {
                    if (c == '+')
                        tot += a;
                    else if (c == '-')
                        tot -= a;
                    else if (c == '*')
                        tot *= a;
                    else if (c == '/')
                        tot /= a;
                    do
                    {
                        Console.Write("Enter the number:");
                        a = Convert.ToInt32(Console.ReadLine());

                        if (c == '+')
                            tot += a;
                        else if (c == '-')
                            tot -= a;
                        else if (c == '*')
                            tot *= a;
                        else if (c == '/')
                            tot /= a;
                        else
                            Console.WriteLine("Err");

                        Console.Write("Enter the Operator:");
                        c = Convert.ToChar(Console.ReadLine());
                    } while (c != '=');
                    Console.Write("Total:" + tot);
                }
                else if (c == '=')
                    Console.WriteLine("Total: " + a);
                else
                    Console.Write("Invalid");
/*            }
            catch (Exception ex)
            {

            };*/
        }
        public void scientificCal()
        {

        }
        public void ProgrammerCal()
        {

        }
        public void DateCalculator()
        {

        }
        static void Main(string[] args)
        {
            int type;

            Program calapp = new Program();

            label:

            Console.WriteLine("Which Type of Calculator You want?");
            Console.WriteLine("1.Simple Calculator");
            Console.WriteLine("2.Scientific Calcu;ator");
            Console.WriteLine("3.Programmer Calculator");
            Console.WriteLine("4.Date Calculation");

            type = Convert.ToInt32(Console.ReadLine());
            switch (type)
            {
                case 1:
                    calapp.SimpleCal();
                    break;
                case 2:
                    calapp.scientificCal();
                    break;
                case 3:
                    calapp.ProgrammerCal();
                    break;
                case 4:
                    calapp.DateCalculator();
                    break;
                default:
                    Console.WriteLine("Inavlild Input");
                    goto label;
            }
            /*
                        int a, tot = 0;
                        char c;

                        Console.Write("Enter the number:");
                        a = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter the Operator:");
                        c = Convert.ToChar(Console.ReadLine());

                        if ((c == '+') || (c == '-') || (c == '*') || (c == '/'))
                        {
                            Console.Write("Enter the number:");
                            int b = Convert.ToInt32(Console.ReadLine());

                            if (c == '+')
                                tot = a + b;
                            else if (c == '-')
                                tot = a - b;
                            else if (c == '*')
                                tot = a * b;
                            else if (c == '/')
                                tot = a / b;

                            Console.Write("Enter the Operator:");
                            c = Convert.ToChar(Console.ReadLine());
                            if (c == '=')
                            {
                                Console.Write("Total:" + tot);
                                //break;
                            }
                            else if((c == '+') || (c == '-') || (c == '*') || (c == '/'))
                            {
                                //Console.Write("Enter the number:");
                                //a = Convert.ToInt32(Console.ReadLine());

                                //Console.WriteLine("Enter the Operator:");
                                //c = Convert.ToChar(Console.ReadLine());

                                while (c != '=')
                                {
                                    Console.Write("Enter the number:");
                                    a = Convert.ToInt32(Console.ReadLine());

                                    if (c == '+')
                                        tot += a;
                                    else if (c == '-')
                                        tot -= a;
                                    else if (c == '*')
                                        tot *= a;
                                    else if (c == '/')
                                        tot /= a;
                                    else
                                        Console.WriteLine("Err");

                                    Console.Write("Enter the Operator:");
                                    c = Convert.ToChar(Console.ReadLine());
                                }
                                Console.Write("Total:" + tot);

                            }
                            else
                                Console.WriteLine("Invalid");
                        }
                        else
                            Console.WriteLine("Invalid");
            */
            Console.Read();

        }
    }
}
