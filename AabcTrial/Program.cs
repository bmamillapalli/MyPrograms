using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AabcTrial
{
    class Program
    {
        static void Main(string[] args)
        {

            double meal = Convert.ToDouble(Console.ReadLine());
            int tip = Convert.ToInt32(Console.ReadLine());
            int tax = Convert.ToInt32(Console.ReadLine());

            double tiptax = (meal * (double)tip / 100 + meal * (double)tax / 100);

            int totalMealCost = (int)(meal + tiptax);

            Console.WriteLine("The total meal cost is " + totalMealCost + " dollars.");



            double d = 5.0;
            double dd = 55.0;
            int a = 5;
            double c = (double)a + d;
            Console.WriteLine((d + dd).ToString("F5"));

            StringBuilder sb = new StringBuilder();


            //bool[] found = new bool[256];

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (found[str[i]])
            //    {
            //        break;
            //    }
            //    sb.Append(str[i]);
            //    found[str[i]] = true;
            //}

            string str = "pwwkew";
            int n = str.Length;
            HashSet<char> set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(str[j]))
                {
                    set.Add(str[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    set.Remove(str[i++]);
                }
            }
            Console.WriteLine("->" + ans);
            Console.WriteLine("The Output String is:" + sb);
            Console.WriteLine("The Output String Length is:" + sb.Length);

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}
