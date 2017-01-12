using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapsEx
{
    class HeapifyEx
    {
        public void BuildMaxHeapify(int[] a)
        {
            for (int i = (a.Length/2 - 1); i >= 0; i--)
            {
                MaxHepify(a, i);
            }
        }
        public void MaxHepify(int[] a, int i)
        {
            i = i + 1;
            int l = 2 * i,
                r = (2 * i) + 1,
                largest;

            if (l <= a.Length && a[l - 1] > a[i - 1])
            {
                largest = l;
            }
            else
            {
                largest = i;
            }
            if (r <= a.Length && a[r - 1] > a[largest - 1])
            {
                largest = r;
            }

            if ((largest - 1)!= (i - 1))
            {

                int temp = a[largest - 1];
                a[largest - 1] = a[i - 1];
                a[i - 1] = temp;
                MaxHepify(a, largest - 1);
            }
        }
        public void BuildMinHeapify(int[] a)
        {
            for (int i = (a.Length/2 - 1); i >=0; i--)
            {
                MinHeapify(a, i);
            }
        }
        public void MinHeapify(int[] a,int i)
        {
            i = i + 1;
            int l = 2 * i,
                r = 2 * i + 1,
                largest;

            if (l <= a.Length && a[l - 1] < a[i - 1])
            {
                largest = l;
            }
            else
            {
                largest = i;
            }
            if (r <= a.Length && a[r - 1] < a[i - 1])
            {
                largest = r;
            }
            if ((largest - 1) != (i - 1))
            {
                int temp = a[largest - 1];
                a[largest - 1] = a[i - 1];
                a[i - 1] = temp;
                MinHeapify(a, largest - 1);
            }
        }
        public int ExtractMaxHeapify(int[] a)
        {
            if (a.Length < 1)
            {
                Console.WriteLine("Error: Heap Under Flow");
            }
            int max = a[0];

            a[0] = a[a.Length - 1];

            MaxHepify(a, 0);


            return max;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HeapifyEx Hobj = new HeapifyEx();

            int[] a = { 1, 2, 3, 4, 5, 6 };
            int[] x = { 6, 5, 4, 3, 2, 1 };
            int[] y = { 6, 5, 4, 3, 2, 1 };

            Console.WriteLine("Max Heap is : " + Hobj.ExtractMaxHeapify(y));

            Hobj.BuildMaxHeapify(a);
            Hobj.BuildMinHeapify(x);

            for (int j = 0; j < a.Length; j++)
            {
                Console.Write(a[j] + " ");
            }
            Console.WriteLine();

            for (int j = 0; j < x.Length; j++)
            {
                Console.Write(x[j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}
