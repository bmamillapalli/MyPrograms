using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueuesEx
{
    class QueuesExClass
    {
        public int index;
        public int rindex;
        public int[] arr;

        public QueuesExClass(int size)
        {
            arr = new int[size];
            index = 0;
            rindex = -1;
        }
        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The Queue Is Full");
            }
            else
            {
                arr[index] = item;
                index++;
            }
        }
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The Queue Is Empty");
                return index;
            }
            else
            {
                index--;
                rindex++;
                return arr[rindex];
            }
        }
        public void Peek()
        {
            if (IsEmpty())
                Console.WriteLine("The Queue Is Empty");
            else
                Console.WriteLine("The First Element Of Queues is: " + arr[rindex]);
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
            QueuesExClass Qobj = new QueuesExClass(10);
            Random rnd = new Random();

            bool found = true;
            while (found)
            {
                Console.WriteLine("\nWhat operation You want to perform?");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Exit");
                int sel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (sel)
                {
                    case 1:
                        /*
                        for (int i = 0; i < Qobj.arr.Length; i++)
                        {
                            Qobj.Enqueue(rnd.Next(1, 10));
                        }*/

                        Console.WriteLine("Enter The Value You Want to Enqueue");
                        int item = Convert.ToInt32(Console.ReadLine());
                        Qobj.Enqueue(item);

                        /*while (true)
                        {
                            Console.WriteLine("Enter The Value You Want to Push");
                            int item = Convert.ToInt32(Console.ReadLine());
                            Qobj.Enqueue(item);

                            Console.WriteLine("Want To Push Onemore?");
                            int c = Convert.ToChar(Console.ReadLine());
                            if (c == 'y')
                                continue;
                            else
                                break;
                        }*/

                        for (int i = (Qobj.arr.Length - 1); i >= 0; i--)
                        {
                            Console.WriteLine("| " + Qobj.arr[i] + " |");
                        }
                        Console.WriteLine("|___|");

                        break;
                    case 2:
                        Console.WriteLine("Popped Out Element is: " + Qobj.Dequeue());
                        break;
                    case 3:
                        Qobj.Peek();
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
