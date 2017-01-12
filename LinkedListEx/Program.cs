using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
/*
    class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void PrintNode()
        {
            Console.Write("|" + data + "->");
            if (next != null)
                next.PrintNode();
        }
        public void AddSorted(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
        public void AddElementToEnd(int data)
        {
            if (next == null)
                next = new Node(data);
            else
                next.AddElementToEnd(data);
        }
    }

    class MyList
    {
        public Node headnode;

        public MyList()
        {
            headnode = null;
        }
        public void AddSortData(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else if (data < headnode.data)
            {
                AddToBeggining(data);
            }
            else
                headnode.AddSorted(data);
        }
        public void AddToBeggining(int data)
        {
            if (headnode == null)
                headnode = new Node(data);
            else
            {
                Node temp = new Node(data);
                temp.next = headnode;
                headnode = temp;
            }
        }
        public void AddToEnd(int data)
        {
            if (headnode == null)
                headnode = new Node(data);
            else
                headnode.AddElementToEnd(data);
        }
        public void Print()
        {
            if (headnode != null)
                headnode.PrintNode();
        }
    }
*/

    class Node
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null;
        }
        public void AddToEndNode(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEndNode(data);
            }
        }
        public void AddDataSortNode(int data)
        {
            if(next == null)
            {
                next = new Node(data);
            }
            else if(data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else
            {
                next.AddDataSortNode(data);
            }
        }
        public void PrintNode()
        {
            Console.Write(" |" + data + " -->");
            if (next != null)
            {
                next.PrintNode();
            }
        }
    }

    class MyList
    {
        public Node headnode;

        public MyList()
        {
            headnode = null;
        }
        public void AddToBegginig(int data)
        {
            if(headnode == null)
            {
                headnode = new Node(data);
            }
            else
            {
                Node temp = new Node(data);
                temp.next = headnode;
                headnode = temp;
            }
        }
        public void AddToEnd(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else
            {
                headnode.AddToEndNode(data);
            }
        }
        public void AddDataSort(int data)
        {
            if (headnode == null)
            {
                headnode = new Node(data);
            }
            else if( data < headnode.data)
            {
                AddToBegginig(data);
            }
            else
            {
                headnode.AddDataSortNode(data);
            }
        }
        public void Print()
        {
            if (headnode != null)
            {
                headnode.PrintNode();
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            MyList Lobj = new MyList();
/*            Lobj.AddToEnd(9);
            Lobj.AddToEnd(15);
            Lobj.AddToEnd(25);
            Lobj.Print();
            Console.WriteLine();
            Lobj.AddToBegginig(150);
            Lobj.AddDataSort(250);
            Lobj.Print();
*/

            while (true)
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
                        Lobj.AddToBegginig(item);
                        break;
                    case 2:
                        //                        Console.WriteLine("Popped Out Element is: " + Lobj.DeletNode());
                        break;
                    case 3:
                        //                        Lobj.Peek();
                        Lobj.Print();
                        break;
                    case 4:
                        goto Done;
                    //break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;


                }
            }
            Done:

            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit");
            Console.Read();
        }
    }
}
