using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvinashBavaQuestions
{
    class Program
    {
        public void Application1(int[] arr1)
        {
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                while (arr1[i] > 0)
                {
                    arr2[i] = ((arr2[i] * 10) + (arr1[i] % 10));
                    arr1[i] = arr1[i] / 10;
                }
            }
            Array.Sort(arr2);
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }

        public void Application2(int[] arr1)
        {
            int[] arr2 = new int[arr1.Length];
            int[] arr3 = new int[arr1.Length];
            int k = 0;
 /*           for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            */
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        arr3[k] = arr1[i];
                        k++;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 25, 56, 13, 45, 13, 75, 25, 89, 45};

            int[] arr2 = new int[arr1.Length];
            int[] arr3 = new int[arr1.Length];
            int k = 0;
            /*           for (int i = 0; i < arr1.Length; i++)
                       {
                           arr2[i] = arr1[i];
                       }
                       */
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = i; j < arr1.Length; j++)
                {
                    if((i != j)&&(arr1[i] == arr1[j]))
                    {
                        arr3[k] = arr1[j];
                        k++;
                    }
                }
            }

            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            Program obj = new Program();
           // obj.Application2(x);
            
            Console.Read();
        }
    }
}
