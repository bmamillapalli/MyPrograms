using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTechniquesEx
{
    class SearchEx
    {
        public int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        bool flag;

        public void LinearSearch()
        {
            int item = 5, index;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == item)
                {
                    index = i;
                    Console.WriteLine("The Index Of The Element is : " + index);
                    flag = true;
                }
            }
            if (!flag)
                Console.WriteLine("Element Not Found");
        }
        public void BinarySearch()
        {
            int val = 15;
            int low = 0, high = (x.Length - 1), mid = 0;

            while (true)
            {
                mid = low + (high - low) / 2;

                if (x[mid] < val)
                {
                    low = mid;
                }
                else if (x[mid] > val)
                {
                    high = mid;
                }
                else if (x[mid] == val)
                {
                    Console.WriteLine("The Index Of The Element is: " + mid);
                    break;
                }
                else
                {
                    Console.WriteLine("Element Not Found");
                    break;
                }

            }
        }
        public void InterpolationSearch()
        {
            int val = 10, low = 0, mid = 0, high = (x.Length - 1);

            while (true)
            {
                mid = low + ((high - low) / (x[high] - x[low])) * (val - x[low]);
                Console.WriteLine("Mid: " + mid);

                if (x[mid] > val)
                {
                    high = mid;
                }
                else if (x[mid] < val)
                {
                    low = mid;
                }
                else if (x[mid] == val)
                {
                    Console.WriteLine("Index Of Element is: " + mid);
                    break;
                }
                else
                {
                    Console.WriteLine("Element Not Found");
                    break;
                }
            }
        }

        public void aaa()
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };
            int val = 55;
            int low = 0;
            int high = a.Length;

            while (true)
            {
                int mid = (high + low) / 2;
                if (high < low)
                {
                    Console.WriteLine("Not Found");
                }

                if (a[mid] == val)
                {
                    Console.WriteLine("Found");
                    break;
                }
                else if (a[mid] > val)
                {
                    high = mid;
                }
                else if (a[mid] < val)
                {
                    low = mid + 1;
                }
            }
        }
        static void Main(string[] args)
        {
            SearchEx Sobj = new SearchEx();
            //Sobj.LinearSearch();
            //Sobj.BinarySearch();
            //Sobj.InterpolationSearch();
            Sobj.aaa();

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}
