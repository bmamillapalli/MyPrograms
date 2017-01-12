using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackEx
{
    class StackExClass
    {
        public int index;
        int[] arr;

        public StackExClass(int size)
        {
            arr = new int[size];
            index = 0;
        }
        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The Stack IS Full");
            }
            else
            {
                arr[index] = item;
                index++;
            }
        }
        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Stack Is Empty");
                return index;
            }
            else
            {
                index--;
                return arr[index];
            }
        }
        public void Peek()
        {
            if (index > 0)
                Console.WriteLine("The Current Element is: " + arr[index - 1]);
            else if (IsEmpty())
                Console.WriteLine("The Stack Is Empty");
        }
        public bool IsFull()
        {
            if (index == arr.Length)
                return true;
            else
                return false;
        }
        public bool IsEmpty()
        {
            if (index == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            StackExClass Sobj = new StackExClass(10);
            Random rnd = new Random();
            bool found = true;

            while (found)
            {
                Console.WriteLine("\nWhat operation You want to perform?");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Exit");
                int sel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (sel)
                {
                    case 1:
                       
                        Console.WriteLine("Enter The Value You Want to Push");
                        int item = Convert.ToInt32(Console.ReadLine());
                        Sobj.Push(item);

                        for (int i = (Sobj.arr.Length - 1); i >= 0; i--)
                        {
                            Console.WriteLine("| " + Sobj.arr[i] + " |");
                        }
                        Console.WriteLine("|___|");

                        break;
                    case 2:
                        Console.WriteLine("Popped Out Element is: " + Sobj.Pop());
                        break;
                    case 3:
                            Sobj.Peek();
                            break;
                    case 4:
                        found = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}
