using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelABCD
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] powerIndex = new int[3];
            int[] places = new int[3];
            int[] itretions = new int[3];
            int index = 0;

            Console.WriteLine("Enter any number which you want to convert: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            //          Console.WriteLine("N-Root: " + Math.Pow(x1, 1.0 / 26));
            if ((x1 == 26) || (x1 == 676))
                index--;

            while (x1 != 0)
                {
                    index++;
                        x1 = x1 / 26;
                }
            Console.WriteLine("Index: " + index);




/*            int temp = 2;
            do
            {
                int t = x1 / 26;
                char ct = (char)(t + 64);
                int o = x1 % 26;
                char co = (char)(o + 64);
                

                // tens
                if (t == 1)
                {
                    if (t==1 && o == 0)
                    {
                        Console.WriteLine("------------" + "t-ct : " + t + "-" + ct);
                    }
                    else
                    {
                        if (o==0)
                        {
                            Console.WriteLine("t-ct : " + t + "-" + (char)(ct-1));
                        }
                        else
                            Console.WriteLine("t-ct : " + t + "-" + ct);
                    }

                }

                // ones
                if (t >= 1 && o==0)
                {
                    Console.WriteLine("o-co : " + o + "-" + (char)(co+26));
                }
                else
                Console.WriteLine("o-co : " + o + "-" + co);


                temp--;
            } while (temp == 0);








            Console.Read();
            return;


            int[] a = new int[26];
            char[] c = new char[26];

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = (char)(i + 65);
            }

            try
            {
                Console.WriteLine("Enter your Number between (1-18728) that You want to converted:");
                int x = Convert.ToInt32(Console.ReadLine());


                int y = x / 26;
                int y2 = x / 676;
                int z = x % 26;
                int z2 = x % 676;
                int iz2 = z2 / 26;


                if (x <= 26)
                {
                    if (y == 0 || (y == 1 && z == 0))
                        Console.WriteLine("Converted code is: " + c[x - 1]);
                }
                if (x > 26 && x <= 702)
                {
                    if (z != 0)
                        Console.WriteLine("Converted code is: " + c[y - 1] + "" + c[z - 1]);
                    if (z == 0)
                        Console.WriteLine("Converted code is: " + c[y - 2] + "" + c[25]);
                }

                if (x > 702 && x <= 18278)
                {
                    if (x == 18278)
                        Console.WriteLine("Converted code is: " + c[25] + "" + c[25] + "" + c[25]);
                    else if (z != 0)
                    {
                        if (iz2 != 0)
                        {
                            Console.WriteLine("Converted code is: " + c[y2 - 1] + "" + c[iz2 - 1] + "" + c[z - 1]);
                        }
                        if (iz2 == 0)
                        {
                            Console.WriteLine("Converted code is: " + c[y2 - 2] + "" + c[25] + "" + c[z - 1]);
                        }

                    }
                    else if (z == 0)
                    {
                        if (z2 != 0)
                        {
                            Console.WriteLine("Converted code is: " + c[y2 - 1] + "" + c[iz2 - 2] + "" + c[25]);
                        }
                        if (z2 == 0)
                        {
                            Console.WriteLine("Converted code is: " + c[y2 - 2] + "" + c[24] + "" + c[25]);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
*/

            Console.Read();
        }
    }
}
