using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperation
{
    class Stack
    {
        int index;
        char[] c;

        public Stack(int size)
        {
            c = new char[size];
            index = 0;
        }

        public void Push(char ch)
        {
            if (index < c.Length)
            {
                c[index] = ch;
                index++;
            }
            else
                Console.WriteLine("Is Full/Edit");
        }

        public char Pop()
        {
            if (index==0)
            {
                Console.WriteLine("Is Empty/Edit");
                return (char)index;
            }
            else
            {
                index--;
                return c[index];
            }            
        }

        public bool IsFull()
        {
            return index == c.Length;
        }

        public bool IsEmpty()
        {
            return index == 0;
        }

        public int Capacity()
        {
            return c.Length;
        }

        public int Index()
        {
            return index;
        }
    }

    class StackDemo
    {
        static void Main(string[] args)
        {
            Stack obj1 = new Stack(26);

            for(int i=0;i< obj1.Capacity(); i++)
            {
            //    obj1.Push((char)(i+65));
                Console.WriteLine(((char)(i+65)));
            }

            for (int i = 0; i < obj1.Capacity(); i++)
            {
                if (!obj1.IsEmpty())
                    Console.Write(obj1.Pop());
            }

            Console.Read();
        }
    }
}
