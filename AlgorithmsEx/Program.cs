using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsEx
{
    class ArraysEx
    {
        public int[] InsertionOperation(int[] x, out int len)
        {

            int[] z = new int[x.Length + 1];
            int k = 3, val = 50;

            for (int i = 0; i < (x.Length); i++)
            {
                if (i < (k))
                    z[i] = x[i];
                else
                    z[i + 1] = x[i];
            }
            z[k] = val;

            len = z.Length;
            return z;
        }

        public int[] DeletionOperation(int[] x, out int len)
        {
            int[] z = new int[x.Length - 1];

            int k = 5;
            for (int i = 0; i < z.Length; i++)
            {
                if (i < k)
                    z[i] = x[i];
                else
                    z[i] = x[i + 1];
            }

            len = z.Length;
            return z;
        }

        public void SearchOperation(int[] x)
        {
            int val = 8;
            bool flag = true;
            for (int i = 0; i < x.Length; i++)
            {
                if (val == x[i])
                {
                    Console.WriteLine("The Index Where the Value is Present is: " + i);
                    flag = false;
                }
            }
            if (flag)
            {
                Console.WriteLine("Value is Not Present");
            }
        }

        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int len;
            int[] z;

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();

            ArraysEx Aobj = new ArraysEx();

            z = Aobj.InsertionOperation(x, out len);
            z = Aobj.DeletionOperation(x, out len);
            Aobj.SearchOperation(x);

            Console.WriteLine();
            for (int i = 0; i < len; i++)
            {
                Console.Write(z[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Enter Any Key To Exit");
            Console.Read();

        }
    }
}
