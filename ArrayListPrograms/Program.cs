using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListPrograms
{
    class Program
    {
        public void arrayCopy()
        {
            int[] a = new int[] { 0, 1, 2, 3, 50 };
            int[] b = new int[] { 0, 0, 0, 0, 0 };

            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
                Console.WriteLine("The a[" + i + "] is: " + a[i] + " and The b[" + i + "] is: " + b[i]);
            }
        }

        public void arrayPositionCopy()
        {
            int[] a = new int[] { 0, 1, 2, 3, 50, 100, 150 };
            int[] b = new int[3];

            Array.Copy(a, 3, b, 0, 3);

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" "+a[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(" " + b[i]);
            }
        }
        public void arrayReverse()
        {

        }
        public void arrayReplace()
        {
            string[] a = new[] { "Brahmi", "Kowsik", "Mamillapalli" };

            Console.WriteLine();
            Console.WriteLine("Array:");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }

            a[1] = a[1].Replace("Kowsik", "k");

            Console.WriteLine();
            Console.WriteLine("New Array:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(" " + a[i]);
            }
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            program.arrayCopy();
            program.arrayPositionCopy();
            program.arrayReverse();
            program.arrayReplace();
                          
            Console.Read();
        }
    }
}
