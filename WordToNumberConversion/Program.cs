using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordToNumberConversion
{
    class Program
    {
        public void N2W()
        {
            int k = 0, m = 0, zzz;
            int[] p = new int[3];          
            string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                           "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "EightTeen", "Nineteen" };
            string[] tens = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Sventy", "Eighty", "Ninety", "Hundred" };
            string[] t = { "", "", "Thousand", "Million", "Billion", "Trillion" };
            string aa, emty = "";

            Console.WriteLine("Enter The Number:");
            int x = Convert.ToInt32(Console.ReadLine());

            int temp = x;
            int[] temp1 = new int[15];

            while (temp > 0)
            {
                temp1[k] = temp % 10;
                temp = temp / 10;
                k++;

            }

            int size,loops;

            loops = k / 3;
            size = k % 3;
            if (size == 1 || size == 2)
            {
                loops++;
            }

            Console.WriteLine("Loop Size: " + loops);

            m = loops*3-1;
            for (int i = loops; i > 0; i--)
            {
                p[2] = temp1[m--];
                p[1] = temp1[m--];
                p[0] = temp1[m--];

                aa = string.Join(emty, Convert.ToString(p[1]), Convert.ToString(p[0]));
                zzz = Int32.Parse(aa);

                if (zzz > 10 && zzz < 20)
                {
                    if (p[0] != 0 && p[1] != 0 && p[2] != 0)
                    {
                        Console.Write(words[p[2]] + " " + tens[10] + " " + words[zzz] + " ");
                    }
                    else
                    {
                        Console.Write(words[zzz] + " ");
                    }
                }
                else if (p[0] == 0 && p[1] == 0 && p[2] == 0) { }
                else if (p[0] == 0 && p[1] == 0 && p[2] != 0)
                {
                    Console.Write(words[p[2]] + " " + tens[10] + " ");
                }
                else if (p[0] == 0 && p[1] != 0 && p[2] == 0)
                {
                    Console.Write(tens[p[1]] + " ");
                }
                else if (p[0] != 0 && p[1] == 0 && p[2] == 0)
                {
                    Console.Write(words[p[0]] + " ");
                }
                else if (p[0] == 0 && p[1] != 0 && p[2] != 0)
                {
                    Console.Write(words[p[2]] + " " + tens[10] + " " + tens[p[1]] + " ");
                }
                else if (p[0] != 0 && p[1] == 0 && p[2] != 0)
                {
                    Console.Write(words[p[2]] + " " + tens[10] + " " + words[p[0]] + " ");
                }
                else if (p[0] != 0 && p[1] != 0 && p[2] == 0)
                {
                    Console.Write(tens[p[1]] + " " + words[p[0]] + " ");
                }
                else
                {
                    Console.Write(words[p[2]] + " " + tens[10] + " " + tens[p[1]] + " " + words[p[0]] + " ");
                }

                if ((i != 1))
                    Console.Write(t[i] + " ");
            }
            Console.ReadLine();
        }
        public void W2N()
        {
            Console.WriteLine("Logic Yet To Be Written");
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();

            Label:

            Console.WriteLine("Enter What type of Conversion You Want to do?");
            Console.WriteLine("1.Number To Word");
            Console.WriteLine("2.Word To Number");
            int sel = Convert.ToInt32(Console.ReadLine());

            switch (sel)
            {
                case 1:
                    obj.N2W();
                    break;
                case 2:
                    obj.W2N();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    goto Label;
            }

            /*Repeat:
            Console.WriteLine("Do you want to Exit The Program? \nYes(y) or No(n)");
            char c = Convert.ToChar(Console.ReadLine());
            if (c == 'n') goto Label;
            else if (c == 'y') Finish;
            else if ((c != 'y') || (c != 'n'))
            {
                Console.WriteLine("Invalid Option");
                goto Repeat;
            }
            Finish:*/

        }
    }
}
