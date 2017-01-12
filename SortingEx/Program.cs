using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingEx
{
    class BubbleExClass
    {
        public void BubbleMtd()
        {
            int[] x = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("Array Before Sorting: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < (x.Length - 1); j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        int temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                    }
                }
                Console.WriteLine("\n*********Begin***********");
                for (int k = 0; k < x.Length; k++)
                {
                    Console.Write(x[k] + " ");
                }
                Console.WriteLine("\n**********End***********");
            }

            Console.WriteLine("\n\nArray After Sorting: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
    }

    class InsertionExClass
    {
        public void InsertionMtd()
        {

            int[] x = new int[10];
            Random rnd = new Random();
            for (int j = 0; j < x.Length; j++)
            {
                x[j] = rnd.Next(1, 100);
            }

            Console.WriteLine("Array Before Sorting: ");
            for (int j = 0; j < x.Length; j++)
            {
                Console.Write(x[j] + " ");
            }

            for (int i = 1; i < (x.Length); i++)
            {
                int val = x[i];
                int j = i - 1;

                while ((j >= 0) && (x[j] >= val))
                {
                    x[j + 1] = x[j];
                    j--;

                    Console.WriteLine("\n\n");
                    for (int k = 0; k < x.Length; k++)
                    {
                        Console.Write(x[k] + " ");
                    }
                }
                x[j + 1] = val;
                Console.WriteLine("\n*********Begin***********");
               for (int k = 0; k < x.Length; k++)
                {
                    Console.Write(x[k] + " ");
                }
                Console.WriteLine("\n**********End***********");

            }


            Console.WriteLine("\nArray After Sorting: \n");
            for (int j = 0; j < x.Length; j++)
            {
                Console.Write(x[j] + " ");
            }
        }
    }

    class SelectionExClass
    {
        public void SelectionMtd()
        {
            
            int[] x = new int[20];
            Random rnd = new Random();
            for (int j = 0; j < x.Length; j++)
            {
                x[j] = rnd.Next(1, 100);
            }

            Console.WriteLine("Array Before Sorting: ");
            for (int j = 0; j < x.Length; j++)
            {
                Console.Write(x[j] + " ");
            }

            for (int i = 0; i < x.Length; i++)
            {
                int min = i;
                for (int j = i; j < (x.Length); j++)
                {
                    if (x[j] <= x[min])
                        min = j;
                }
                if (min != i)
                {
                    int temp = x[min];
                    x[min] = x[i];
                    x[i] = temp;
                }

                Console.WriteLine("\n*********Begin***********");
                for (int k = 0; k < x.Length; k++)
                {
                    Console.Write(x[k] + " ");
                }
                Console.WriteLine("\n**********End***********");
            }

            Console.WriteLine("\nArray After Sorting: \n");
            for (int j = 0; j < x.Length; j++)
            {
                Console.Write(x[j] + " ");
            }
        }
    }

    class MergeExClass
    {
        public void MergeMtd(int[] x, int p, int r)
        {
//            int q;
            if (p < r)
            {
                int q = (int)(Math.Floor((Convert.ToDouble(p) + Convert.ToDouble(r)) / 2));
                Console.WriteLine("p:" + p + " q:" + q + " r:" + r);
                MergeMtd(x, p, q);
                MergeMtd(x, q + 1, r);
                SortingMtd(x, p, q, r);
            }           
        }
        public void SortingMtd(int[] x, int p, int q, int r)
        {
            int[] temp = new int[x.Length];
            int i = p,
                j = q + 1,
                k = 0;

            while(i <= q && j <= r)
            {
                if (x[i] < x[j])
                {
                   
                    temp[k++] = x[i++];
                }
                else
                {
                    temp[k++] = x[j++];
                }
            }

                while (i <= q)
            {
                temp[k++] = x[i++];
            }
            while (j <= r)
            {
                temp[k++] = x[j++];
            }
            for (i = r; i >= p; i--)
            {
                x[i] = temp[--k];
            }
            Console.WriteLine("\n");
            for (int kk = 0; kk < x.Length; kk++)
            {
                Console.Write(x[kk] + " ");
                //Console.WriteLine("");
                //Console.Write(temp[kk] + "-");
            }
        }
    }

    class QuickExClass
    {
        public void QuickSorting(int[] x, int p, int r)
        {
            if (p >= r)
            {
                return;
            }

            int i = p,
                j = r,
                pivot = x[p];

            while (i < j)
            {
                while((i < j) && (x[j] >= pivot))// && (x[j] != pivot))
                    j--;
                x[i] = x[j];
                while ((i < j) && (x[i] <= pivot))// && (x[i] != pivot))
                    i++;
                x[j] = x[i];
            }
            x[i] = pivot;
            QuickSorting(x, p, i - 1);
            QuickSorting(x, i + 1, r);

            Console.WriteLine("\n After Sorting:");
            for (int k = 0; k < x.Length; k++)
            {
                Console.Write(x[k] + " ");
            }
        }
    }

    class HeapExClass
    {
        public void HeapSorting()
        {

        }
    }
    class SortingExClass
    {
        static void Main(string[] args)
        {
            /*
            int[] x = new int[20];
            Random rnd = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = rnd.Next(1, 100);
            }

            Console.WriteLine("Array Before Sorting: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
            */
            int[] x = { 5, 4, 3, 2, 1 };

            //101,115,145,65,55,66,77,852,568,520,10,10, 9, 8, 7, 100, 
            //BubbleExClass Bobj = new BubbleExClass();
            //Bobj.BubbleMtd();
            //InsertionExClass Iobj = new InsertionExClass();
            //Iobj.InsertionMtd();
            //SelectionExClass Sobj = new SelectionExClass();
            //Sobj.SelectionMtd();
            MergeExClass Mobj = new MergeExClass();
            Mobj.MergeMtd(x, 0, x.Length - 1);
            //QuickExClass Qobj = new QuickExClass();
            //Qobj.QuickSorting(x, 0, x.Length - 1);

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}
