using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTechniques
{
    class BubbleSortClass
    {
        public void BubbleSort(int[] x)
        {
            int temp;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 1; j < x.Length; j++)
                {
                    if (x[j - 1] < x[j])
                    {
                        temp = x[j - 1];
                        x[j - 1] = x[j];
                        x[j] = temp;
                    }
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
    }

    class SelectionSortClass
    {
        public void SelectionSort(int[] x)
        {
            for (int i = 0; i < x.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[j] < x[min])
                        min = j;
                }
                int temp = x[i];
                x[i] = x[min];
                x[min] = temp;
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
    }

    class InsertionSortClass
    {
        public void InsertionSort(int[] x)
        {
            for (int i = 1; i < x.Length; i++)
            {
                int index = x[i];
                int j = i;
                while (j >= 0 && x[j] < index)
                {
                    x[j] = x[j - 1];
                    j--;
                }
                x[j] = index;
            }
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
    }

    class QuickSortClass
    {
        public void QuickSort(int[] x)
        {
            Partition(x, 0, x.Length - 1);

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        public void Partition(int[] x,int p,int r) 
        {
            if (p >= r)
            {
                return;
            }

            int pivot = x[p];
            int i = p;
            int j = r;

            while (i < j)
            {
                while ((x[j] > pivot) && (i < j))
                {
                    j--;
                }
                x[i] = x[j];

                while ((x[i] <= pivot) && (i < j))
                {
                    i++;
                }
                x[j] = x[i];

            }

            x[i] = pivot;

            Partition(x, p, i - 1);

            Partition(x, i + 1, r);
        }
    }

    class QuickSort2Class
    {
        public void QuickSort2(int[] x,int p,int r)
        {
            if (p < r)
            {
                int q = QuickSort22(x, p, r);
                QuickSort2(x, p, q);
                QuickSort2(x, q + 1, r);
            }
        }

        public int QuickSort22(int[] x, int p,int r)
        {
            int pivot = x[r];
            int i = p - 1;
            for (int j = p; j < r-1; j++)
            {
                if (x[j] <= pivot) 
                    {
                    i++;
                    int temp = x[i];
                    x[i] = x[j];
                    x[j] = temp;
                    }
            }
            int temp1 = x[i + 1];
            x[i + 1] = x[r];
            x[r] = temp1;

            return i + 1;
        }
    }

    class MergeSortClass
    {
        public void MergeSort(int[] a, int p, int r)
        {
            if (p < r)
            {
                int q = (int)Math.Floor((Convert.ToDouble(p) + Convert.ToDouble(r)) / 2);
                MergeSort(a, p, q);
                MergeSort(a, q + 1, r);
                Merge(a, p, q, r);
            }
        }

        public void Merge(int[] a, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int[] lt = new int[n1 + 1];
            int[] rt = new int[n2 + 1];

            lt[n1] = rt[n2] = 500;

            for (int ii = 0; ii < lt.Length - 1; ii++)
            {
                lt[ii] = a[p + ii];
            }
            for (int ii = 0; ii < rt.Length - 1; ii++)
            {
                rt[ii] = a[q + ii + 1];
            }

            int i = 0, j = 0;

            for (int k = p; k <= r; k++)
            {
                if ((lt[i] <= rt[j]))
                {
                    a[k] = lt[i];
                    i = i + 1;
                }
                else
                {
                    a[k] = rt[j];
                    j = j + 1;
                }
            }
        }
        /*    class MergeSortClass
    {
        public void MergeSort(int[] x,int p, int r)
        {
            int q;
            if (p < r)
            {
                q = (int)Math.Floor((Convert.ToDouble(p) + Convert.ToDouble(r)) / 2);
                MergeSort(x, p, q);
                MergeSort(x, q + 1, r);
                Merge(x, p, q, r);
            }
        }
        public void Merge(int[] x, int p, int q,int r)
        {
            int[] y = new int[x.Length];
            int i, j, k;
            i = p;
            j = q + 1;
            k = 0;
            
            while(( i <= q) && (j <= r))
            {
                if (x[i] < x[j])
                {
                    y[k++] = x[i++];
                }
                else
                {
                    y[k++] = x[j++];
                }
            }

            while (i <= q)
            {
                y[k++] = x[i++];
            }

            while (j <= r)
            {
                y[k++] = x[j++];
            }

            for (i = r; i >= p; i--)
            {
                x[i] = y[--k];
            }
        } 
    }
*/
    }

    class CallingClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The size Of Array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] x = new int[n];
            Console.Write("Enter The Elements In The Array:");
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt32(Console.ReadLine());
            }

            //int[] x = { 40, 20, 30, 50, 5, 21, 6, 47, 2, 55, 89, 76 };

            Console.WriteLine("The Array Before Sorting: ");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write(x[i] + " ");
            }

            BubbleSortClass Bobj = new BubbleSortClass();
            SelectionSortClass Sobj = new SelectionSortClass();
            InsertionSortClass Iobj = new InsertionSortClass();
            QuickSortClass Qobj = new QuickSortClass();
            QuickSort2Class Qobj2 = new QuickSort2Class();
            MergeSortClass Mobj = new MergeSortClass();

            Console.WriteLine("Enter Which Type of sorting You Want to Do?");
            Console.WriteLine("1. Bubble Sorting");
            Console.WriteLine("2. Selection Sorting");
            Console.WriteLine("3. Insertion Sorting");
            Console.WriteLine("4. Quick Sorting");
            Console.WriteLine("5. Merge Sorting");
            Console.WriteLine("6. ");
            Console.WriteLine("7. ");
            int sel = Convert.ToInt32(Console.ReadLine());

            

            switch (sel)
            {
                case 1:
                    Console.WriteLine();
                    Bobj.BubbleSort(x);
                    break;
                case 2:
                    Console.WriteLine();
                    Sobj.SelectionSort(x);
                    break;
                case 3:
                    Console.WriteLine();
                    Iobj.InsertionSort(x);
                    break;
                case 4:
                    Console.WriteLine();
                    //Qobj.QuickSort(x);
                    Qobj2.QuickSort2(x, 0, x.Length - 1);

                    Console.WriteLine();
                    Console.WriteLine("The Array After Sorting: ");

                    for (int i = 0; i < x.Length; i++)
                    {
                        Console.Write(x[i] + " ");
                    }
                    break;
                case 5:
                    Console.WriteLine();
                    Mobj.MergeSort(x, 0, x.Length - 1);

                    Console.WriteLine();
                    Console.WriteLine("The Array After Sorting: ");

                    for (int i = 0; i < x.Length; i++)
                    {
                        Console.Write(x[i] + " ");
                    }
                    break;
                case 6:
                    Console.WriteLine();
                    break;
                case 7:
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
